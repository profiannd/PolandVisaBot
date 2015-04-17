using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Timer = System.Windows.Forms.Timer;

namespace PolandVisaAuto
{
    public class Engine
    {
        private BindingList<VisaTask> _visaTasks;
 //       private BindingList<VisaTask> _completedVisaTasks;
        private Dictionary<string, VisaTab> _cityTasks;
        private TabControl _tabControl;
        private Timer _timer;
        private List<string> _toRemove = new List<string>();
        private List<VisaTab> _activeTabs = new List<VisaTab>();
        private int _activePointer = 0;
        public static Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
        BackgroundWorker _oWorker = new BackgroundWorker();

        public delegate void ETaskDelegate(VisaTask task);
        public event ETaskDelegate ETaskEvent;

        public Engine(BindingList<VisaTask> visaTasks, TabControl tabControl)//, BindingList<VisaTask> completedVisaTasks)
        {
            _tabControl = tabControl;
            _visaTasks = visaTasks;
//            _completedVisaTasks = completedVisaTasks;
            _cityTasks = new Dictionary<string, VisaTab>();
            _timer = new Timer();
            _timer.Interval = 1500;
            _timer.Tick += _timer_Tick;
            _oWorker.DoWork += new DoWorkEventHandler(_oWorker_DoWork);
        }

        private void SetTabHeader(TabPage page, Color color)
        {
            TabColors[page] = color;
            _tabControl.Invalidate();
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            foreach (string s in _toRemove)
            {
                _cityTasks.Remove(s);
            }
            _toRemove.Clear();

            VisaTab tab = GetVisaTabToStep();
            if(tab != null)
                tab.DoStep();
//            foreach (KeyValuePair<string, VisaTab> keyValuePair in _cityTasks)
//            {
//                keyValuePair.Value.DoStep();
//            }
        }

        private VisaTab GetVisaTabToStep()
        {
            if (_activeTabs.Count != 0)
            {
                if (_activePointer >= _activeTabs.Count)
                    _activePointer = 0;
                return _activeTabs[_activePointer++];
            }
            List<string> sListKey = new List<string>();
            foreach (string key in _cityTasks.Keys)
            {
                sListKey.Add(key);
            }

            if (sListKey.Count == 0)
                return null;

            if(_activePointer >= sListKey.Count)
                _activePointer = 0;
            string newkey = sListKey[_activePointer++];
            if (_cityTasks.ContainsKey(newkey))
                return _cityTasks[newkey];
            return null;
        }

        public void DeleteCityKey(string city)
        {
            if (_cityTasks.ContainsKey(city))
            {
                _cityTasks[city] = null;
                _cityTasks.Remove(city);
            }
        }

        public void DeleteTask(VisaTask visaTask)
        {
            if (_cityTasks.ContainsKey(visaTask.City))
            {
                VisaTab visaTab = _cityTasks[visaTask.City];
                visaTab.CheckOnDeleteTask(visaTask);
            }
        }

        public void RefreshViewTabs()
        {
            _timer.Stop();
//            SetProxy();
            foreach (VisaTask vt in _visaTasks)
            {
                if (!_cityTasks.ContainsKey(vt.City))
                {
                    Logger.Info("Создаю новый таб " + vt.City);
                    TabPage tabPage = new TabPage(vt.City);
                    tabPage.Name = vt.City;
                    WebBrowser webBrowser1 = new WebBrowser();
                    webBrowser1.Size = new Size(837, 400);
                    webBrowser1.Dock = DockStyle.Top;
                    webBrowser1.Location = new Point(0, 0);
                    webBrowser1.Name = "webBrowser" + vt.City;
                    tabPage.Controls.Add(webBrowser1);

                    Button deleteTask = new Button();
                    deleteTask.Location = new System.Drawing.Point(200, 400);
                    deleteTask.Name = "deleteTask";
                    deleteTask.Size = new System.Drawing.Size(200, 40);
                    deleteTask.TabIndex = 4;
                    deleteTask.Text = "Удалить задачу";
                    deleteTask.UseVisualStyleBackColor = true;
                    deleteTask.Visible = false;
                    tabPage.Controls.Add(deleteTask);

                    Button renewTask = new Button();
                    renewTask.Location = new System.Drawing.Point(650, 400);
                    renewTask.Name = "renewTask";
                    renewTask.Size = new System.Drawing.Size(200, 40);
                    renewTask.TabIndex = 4;
                    renewTask.Text = "Возобновить задачу";
                    renewTask.UseVisualStyleBackColor = true;
                    renewTask.Visible = false;
                    tabPage.Controls.Add(renewTask);

                    RichTextBox richText = new RichTextBox();
                    richText.Name = "richText";
                    richText.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                    richText.Location = new Point(0, 451);
                    richText.Size = new Size(837, 200);
                    richText.Dock = DockStyle.Bottom;
                    tabPage.Controls.Add(richText);

                    SetTabHeader(tabPage, Color.LightGreen);
                    _tabControl.TabPages.Add(tabPage);

                    VisaTab visaTab = new VisaTab(vt, tabPage);
                    _cityTasks.Add(vt.City, visaTab);
                }
                else
                {
                    VisaTab tab = _cityTasks[vt.City];
                    if(!tab.Tasks.Contains(vt))
                        tab.Tasks.Add(vt);
                }
            }

            foreach (KeyValuePair<string, VisaTab> pair in _cityTasks)
            {
                pair.Value.TaskEvent -= Value_TaskEvent;
                pair.Value.TaskEvent += Value_TaskEvent;
                pair.Value.TabEvent -= Value_TabEvent;
                pair.Value.TabEvent += Value_TabEvent;
                pair.Value.TabEventEx -= Value_TabEventEx;
                pair.Value.TabEventEx += Value_TabEventEx;
                pair.Value.VisaEvent -= ValueVisaEvent;
                pair.Value.VisaEvent += ValueVisaEvent;
                pair.Value.GetNextProxyEvent -= Value_GetNextProxyEvent;
                pair.Value.GetNextProxyEvent += Value_GetNextProxyEvent;

            }
            _timer.Start();
        }

        void Value_GetNextProxyEvent()
        {
            SelectNextProxy();
        }

        void ValueVisaEvent(VisaTab tab, bool add)
        {
            if (add)
                _activeTabs.Add(tab);
            else
                _activeTabs.Remove(tab);
        }

        void Value_TabEventEx(TabPage tab, bool alarm)
        {
            if (alarm)
                SetTabHeader(tab, Color.LightPink);
            else
                SetTabHeader(tab, Color.LightGreen);
        }

        private void Value_TabEvent(TabPage tab)
        {
            if (tab.Text.IndexOf("~") != -1 )
                tab.Text = tab.Text.Remove(tab.Text.IndexOf("~"));
            Logger.Info("Удаляю таб " + tab.Text);
            _toRemove.Add(tab.Text);
            _tabControl.TabPages.Remove(tab);
            _cityTasks.Remove(tab.Text);
        }
        
        void Value_TaskEvent(VisaTask task)
        {
            if (ETaskEvent != null)
                ETaskEvent(task);
        }

        #region Proxy, Ping

        public void SetProxy()
        {
            if (!ImageResolver.Instance.UseProxy)
                return;

            while (!PingHost(ImageResolver.Instance.CurrentWebProxy))
            {
                SelectNextProxy();
            }

            Proxy.Set(ImageResolver.Instance.CurrentWebProxy);
            Logger.Info("SetProxy " + ImageResolver.Instance.CurrentWebProxy.Address.Host + " " + ImageResolver.Instance.CurrentWebProxy.Address.Port);

            ExecPingHost();
            //            const string key = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
            //
            //            RegistryKey regKey = Registry.CurrentUser.OpenSubKey(key, true);
            //            if (regKey != null)
            //            {
            //                regKey.SetValue("ProxyServer", proxy);
            //                regKey.SetValue("ProxyEnable", 1);
            //            }
        }
        
        public void ExecPingHost()
        {
            _oWorker.RunWorkerAsync();
        }

        private bool _isProgress = false;
        private void SelectNextProxy()
        {
            if (_isProgress)
                return;
            _isProgress = true;
            while (true)
            {
                ImageResolver.Instance.WebProxies.Enqueue(ImageResolver.Instance.WebProxies.Dequeue());
                WebProxy webProxy = ImageResolver.Instance.WebProxies.Peek();
                if (PingHost(webProxy))
                {
                    ImageResolver.Instance.CurrentWebProxy = webProxy;
                    Logger.Info("SetProxy " + ImageResolver.Instance.CurrentWebProxy.Address.Host + " " + ImageResolver.Instance.CurrentWebProxy.Address.Port);
                    Proxy.Set(ImageResolver.Instance.CurrentWebProxy);
                    ImageResolver.Instance.SaveCurrentProxyList();
                    _isProgress = false;
                    return;
                }
            }
        }

        private void _oWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(10000);
                if (!PingHost(ImageResolver.Instance.CurrentWebProxy))
                    SelectNextProxy();
            }
        }

        private bool PingHost(WebProxy proxy)
        {
            return PingHost(proxy.Address.Host);
        }

        private static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(nameOrAddress, 1000);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
            }

            return pingable;
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PolandVisaAuto
{
    public class Engine
    {
        private BindingList<VisaTask> _visaTasks;
        private Dictionary<string, VisaTab> _cityTasks;
        private TabControl _tabControl;
        private Timer _timer;
        List<string> _toRemove = new List<string>();
        public static Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();

        public Engine(BindingList<VisaTask> visaTasks, TabControl tabControl)
        {
            _tabControl = tabControl;
            _visaTasks = visaTasks;
            _cityTasks = new Dictionary<string, VisaTab>();
            _timer = new Timer();
            _timer.Interval = 1500;
            _timer.Tick += _timer_Tick;
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
            foreach (KeyValuePair<string, VisaTab> keyValuePair in _cityTasks)
            {
                keyValuePair.Value.DoStep();
            }
        }

        public void DeleteTask(VisaTask visaTask)
        {
            foreach (VisaTask vt in _visaTasks)
            {
                if (_cityTasks.ContainsKey(vt.City))
                {
                   VisaTab visaTab = _cityTasks[vt.City];
                   visaTab.CheckOnDeleteTask(visaTask);
                }
            }
        }

        public void RefreshViewTabs()
        {
            _timer.Stop();
            foreach (VisaTask vt in _visaTasks)
            {
                if (!_cityTasks.ContainsKey(vt.City))
                {
                    Logger.Info("Создаю новый таб " + vt.City);
                    TabPage tabPage = new TabPage(vt.City);
                    WebBrowser webBrowser1 = new WebBrowser();
                    webBrowser1.Size = new Size(837, 300);
                    webBrowser1.Dock = DockStyle.Top;
                    webBrowser1.Location = new Point(0, 0);
                    webBrowser1.Name = "webBrowser" + vt.City;
                    tabPage.Controls.Add(webBrowser1);

                    RichTextBox richText = new RichTextBox();
                    richText.Name = "richText";
                    richText.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                    richText.Location = new Point(0, 303);
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
            }
            _timer.Start();
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
            Logger.Info("Удаляю таб " + tab.Text);
            _toRemove.Add(tab.Text);
            _tabControl.TabPages.Remove(tab);
        }

        void Value_TaskEvent(VisaTask task)
        {
            _visaTasks.Remove(task);
        }
    }
}

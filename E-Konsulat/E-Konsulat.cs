using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using PolandVisaAuto;
using pvhelper;

namespace E_Konsulat
{
    public partial class Form1 : Form
    {
        private BindingList<KonsulatTask> _tasks = new BindingList<KonsulatTask>();
        private BindingList<KonsulatTask> _completedTasks = new BindingList<KonsulatTask>();
        private Engine _engine;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateHeader();
            chbAutoResolveImage.Checked = ImageResolver.Instance.AutoResolveImage;
            radiocom.Checked = ImageResolver.Instance.Host == radiocom.Text;
            radioinfo.Checked = ImageResolver.Instance.Host == radioinfo.Text;
            chbProxy.Checked = ImageResolver.Instance.UseProxy;

//            cbxCity.DataSource = Const.GetListFromDict(Const.SettingsCities);
//            cbxNation.DataSource = Const.GetListFromDict(Const.FillNations());
//            cbxStatus.DataSource = Const.GetListFromDict(Const.FillStatus());
//            cbxPurpose.DataSource = Const.GetListFromDict(Const.FillPurpose());
//            cbxCategory.DataSource = Const.GetListFromDict(Const.GetCategoryType());
            cbxPriority.DataSource = Const.GetListPriority();

//            cityDataGridViewComboBoxColumn.DataSource = Const.GetListFromDict(Const.SettingsCities);
//            priorityComboBoxColumn.DataSource = Const.GetDataTablePriority();
//
//            cbxStatus.SelectedItem = "Mr.";
//            cbxNation.SelectedItem = "UKRAINE";

            _tasks = KonsulatTask.DeSerialize(KonsulatTaskEntityType.New);
            _engine = new Engine(_tasks, tabControl1);//, _completedVisaTasks);

            //!! 
            // _engine.SetProxy();
            _engine.RefreshViewTabs();
            _engine.ETaskEvent += _engine_ETaskEvent;


        }

        private void UpdateHeader()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            this.Text += version + "   De-Captcher Balance: " + ImageResolver.Instance.GetBalance() + "$";
        }

        void _engine_ETaskEvent(KonsulatTask task)
        {
           // WriteReportFile(task);
            RemoveTask(task);
        }

        private void RemoveTask(KonsulatTask vt)
        {
            _tasks.Remove(vt);
            KonsulatTask.Save(_tasks, KonsulatTaskEntityType.New);
            _completedTasks.Add(vt);
            KonsulatTask.Save(_completedTasks, KonsulatTaskEntityType.Completed);
        }
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            _tasks.Add(fillKonsulatTask());
            KonsulatTask.Save(_tasks, KonsulatTaskEntityType.New);
            _engine.RefreshViewTabs();
        }

        private KonsulatTask fillKonsulatTask()
        {
            KonsulatTask task = new KonsulatTask();
            task.LastName = personalData1.LastName;
            task.FirstName = personalData1.FirstName;
            task.PreviousLastName = personalData1.PreviousLastName;
            task.Dob = personalData1.Dob;
            task.DobCity = personalData1.DobCity;
            task.DobCountry = personalData1.DobCountry;
            task.Citizenship = personalData1.Citizenship;
            task.Nationality = personalData1.Nationality;
            task.SexMRadio = personalData1.SexMRadio;
            task.FamilyStateRadio = personalData1.FamilyStateRadio;



            return task;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainModule.Presenters;
using MetroFramework.Forms;

namespace MainModule.Views
{
    public partial class Dashboard : MetroForm
    {
        private static Dashboard DashboardForm;

        public static Dashboard Instance
        {
            get
            {
                if (DashboardForm == null)
                    DashboardForm = new Dashboard();

                return DashboardForm;
            }
        }

        public static readonly string HeaderText = "EnglishLab";

        private bool CloseFromTray;

        private MainViewPresenter MainViewPresenter;

        private Dashboard()
        {
            InitializeComponent();

            CloseFromTray = false;
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            MainView view = MainView.Instance;
            MainViewPresenter = new MainViewPresenter(view);
            viewPanel.Controls.Add(view);
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool
                shutDown = e.CloseReason == CloseReason.WindowsShutDown,
                taskKill = e.CloseReason == CloseReason.TaskManagerClosing;

            if (shutDown || taskKill)
                return;

            if (!CloseFromTray)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
            }     
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFromTray = true;
            Close();
        }
    }
}
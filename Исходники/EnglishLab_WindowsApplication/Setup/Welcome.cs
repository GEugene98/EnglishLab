using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Setup
{
    public partial class Welcome : UserControl
    {
        public Panel ContainerPanel;
        private Form ParentShellForm;

        public Welcome(Panel panel, Form form)
        {
            InitializeComponent();
            ParentShellForm = form;

            ContainerPanel = panel;

            info.Text = "0.1 Beta";
        }

        private void openDialog_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(path.Text))
            {
                ContainerPanel.Controls.Remove(this);
                ContainerPanel.Controls.Add(new ProcessSetup(path.Text, ParentShellForm));
            }

            else
                MessageBox.Show("Выберите расположение или создайте папку нажав на значок справа от поля ввода", "Выбранного расположения не существует", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

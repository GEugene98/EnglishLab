using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainModule.Views;
using System.IO;

namespace MainModule
{
    public partial class DocViewer : UserControl
    {
        public DocViewer(string path)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            richTextBox1.LoadFile(path);
        }

        private void toMainView_Click(object sender, EventArgs e)
        {
            Panel containerPanel = Dashboard.Instance.viewPanel;

            containerPanel.Controls.Remove(this);
            containerPanel.Controls.Add(MainView.Instance);

            Dashboard.Instance.Text = Dashboard.HeaderText;
            Dashboard.Instance.Refresh();
        }

        bool enabled;
        private void button1_Click(object sender, EventArgs e)
        {
            if (enabled)
            {
                richTextBox1.ForeColor = Color.Black;
                richTextBox1.BackColor = Color.White;
                enabled = false;
            }
            else
            {
                richTextBox1.ForeColor = Color.White;
                richTextBox1.BackColor = Color.Black;
                enabled = true;
            }
        }

        string[] dict = File.ReadAllLines("MainDict.txt");

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            char[] trimers = new char[] { ' ', '.', ',', '!', '?' };

            string
                wordToTranslate = richTextBox1.SelectedText.Trim(trimers),
                translation = "";

            toolTip1.IsBalloon = true;
            toolTip1.UseAnimation = true;
            toolTip1.UseFading = true;

            int count = 0;

            for (int i = 0; i < dict.Length; i++)
            {
                if (dict[i].Contains(wordToTranslate))
                {
                    translation += dict[i] + '\n';
                    count++;
                }

                if (count == 3)
                    break;
            }

            toolTip1.ToolTipTitle = richTextBox1.SelectedText;
            toolTip1.SetToolTip(richTextBox1, translation);
        }
    }
}

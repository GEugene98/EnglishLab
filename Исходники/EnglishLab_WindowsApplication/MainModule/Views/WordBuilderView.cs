using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainModule.Views
{
    public partial class WordBuilderView : UserControl, IWordBuilderView
    {
        public WordBuilderView()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        public string InjectableWord { get; set; }
        public string Description { set => descriptionBox.Text = value; }
        public List<string> PartsOfWord { private get; set; }
        public bool Correct { private get; set; }

        public event EventHandler WordEntered;

        private void toMainView_Click(object sender, EventArgs e)
        {
            Panel containerPanel = Dashboard.Instance.viewPanel;

            containerPanel.Controls.Remove(this);
            containerPanel.Controls.Add(MainView.Instance);

            Dashboard.Instance.Text = Dashboard.HeaderText;
            Dashboard.Instance.Refresh();
        }
    }
}

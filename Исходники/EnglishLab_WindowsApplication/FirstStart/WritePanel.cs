using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace FirstStart
{
    public partial class WritePanel : UserControl
    {
        public WebBrowser Browser
        {
            get
            {
                return browser;
            }
        }

        public string Answer
        {
            get
            {
                return answer.Text;
            }
        }

        public MetroButton NextButton
        {
            get
            {
                return next;
            }
        }

        public WritePanel()
        {
            InitializeComponent();
            Visible = false;
        }

        private void WritePanel_VisibleChanged(object sender, EventArgs e) => answer.Text = "";

        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e) => answer.Text = "";

    }
}

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
    public partial class VariantPanel : UserControl
    {
        public WebBrowser Browser
        {
            get
            {
                return browser;
            }
        }
        public Button[] VariantsArray
        {
            get
            {
                return new Button[] { variant1, variant2, variant3, variant4 };
            }
        }

        public VariantPanel()
        {
            InitializeComponent();
            Visible = false;

            variant1.MouseEnter += Variant_MouseEnter;
            variant2.MouseEnter += Variant_MouseEnter;
            variant3.MouseEnter += Variant_MouseEnter;
            variant4.MouseEnter += Variant_MouseEnter;

            variant1.MouseLeave += Variant_MouseLeave;
            variant2.MouseLeave += Variant_MouseLeave;
            variant3.MouseLeave += Variant_MouseLeave;
            variant4.MouseLeave += Variant_MouseLeave;
        }

        private void Variant_MouseEnter(object sender, EventArgs e) => ((Button)sender).ForeColor = Color.White;

        private void Variant_MouseLeave(object sender, EventArgs e) => ((Button)sender).ForeColor = Color.Black;
    }
}

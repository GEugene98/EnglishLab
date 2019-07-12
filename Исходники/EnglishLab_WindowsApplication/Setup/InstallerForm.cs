using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Setup
{
    public partial class InstallerForm : MetroForm
    {
        public InstallerForm()
        {
            InitializeComponent();

            panel.Controls.Add(new Welcome(panel, this));
        }
    }
}

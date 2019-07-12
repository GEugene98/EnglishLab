using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using UserData;

namespace FirstStart
{
    public partial class StartDialog : MetroForm
    {
        public string UserName { get; private set; }
        public Level UserLevel { get; private set; }

        public StartDialog()
        {
            InitializeComponent();

            levelInfo.SelectedIndex = 0;
        }

        private void userName_Enter(object sender, EventArgs e) => userName.Text = "";

        private void nextButton_Click(object sender, EventArgs e)
        {
            UserName = userName.Text;
            UserLevel = (Level)levelInfo.SelectedIndex;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void StartDialog_FormClosed(object sender, FormClosedEventArgs e) => DialogResult = DialogResult.Abort;
    }
}

using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace FirstStart.Views
{
    public partial class Test : MetroForm, ITestView
    {
        private VariantPanel VariantPanel;
        private WritePanel WritePanel;

        public Test()
        {
            InitializeComponent();

            DialogResult = DialogResult.Abort;

            VariantPanel = new VariantPanel();
            VariantPanel.Dock = DockStyle.Fill;
            panelForQuestion.Controls.Add(VariantPanel);

            VariantPanel.VariantsArray[0].Click += Var0_Click;
            VariantPanel.VariantsArray[1].Click += Var1_Click;
            VariantPanel.VariantsArray[2].Click += Var2_Click;
            VariantPanel.VariantsArray[3].Click += Var3_Click;

            WritePanel = new WritePanel();
            WritePanel.Dock = DockStyle.Fill;
            panelForQuestion.Controls.Add(WritePanel);

            WritePanel.NextButton.Click += NextButton_Click;
        }

        #region Реализация ITestView

        private Mode _Mode;
        public Mode Mode
        {
            get
            {
                return _Mode;
            }

            set
            {
                if (value == Mode.Choose)
                {
                    WritePanel.Visible = false;
                    VariantPanel.Visible = true;
                }
                else if (value == Mode.Answer)
                {
                    VariantPanel.Visible = false;
                    WritePanel.Visible = true; 
                }

                _Mode = value;
            }
        }

        public int Progress
        {
            get
            {
                return progress.Value;
            }
            set
            {
                progress.Value = value;
            }
        }

        public int MaxCountQuestions
        {
            set
            {
                progress.Maximum = value;
            }
        }

        public string Status
        {
            set
            {
                status.Text = value;
            }
        }

        public string Question
        {
            set
            {
                if (Mode == Mode.Answer)
                    WritePanel.Browser.DocumentText = value;
                else if (Mode == Mode.Choose)
                    VariantPanel.Browser.DocumentText = value;
            }
        }

        public string[] Variants
        {
            set
            {
                for (int i = 0; i < value.Length; i++)
                    VariantPanel.VariantsArray[i].Text = value[i];
            }
        }

        private int _SelectedVariant;
        public int SelectedVariant
        {
            get
            {
                return _SelectedVariant;
            }

            private set
            {
                _SelectedVariant = value;
                if (VariantChosen != null) VariantChosen(this, EventArgs.Empty);
            }
        }

        private string _EnteredAnswer;
        public string EnteredAnswer
        {
            get
            {
                return _EnteredAnswer;
            }

            private set
            {
                _EnteredAnswer = value;
                if (AnswerEntered != null) AnswerEntered(this, EventArgs.Empty);
            }
        }

        public event EventHandler FinishClick;
        public event EventHandler SkipClick;
        public event EventHandler VariantChosen;
        public event EventHandler AnswerEntered;

        public void SuccessFinish()
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion

        private void skip_Click(object sender, EventArgs e)
        {
            if (SkipClick != null) SkipClick(this, EventArgs.Empty);
        }

        private void end_Click(object sender, EventArgs e)
        {
            if (FinishClick != null) FinishClick(this, EventArgs.Empty);
        }

        private void Var0_Click(object sender, EventArgs e) => SelectedVariant = 0;

        private void Var1_Click(object sender, EventArgs e) => SelectedVariant = 1;

        private void Var2_Click(object sender, EventArgs e) => SelectedVariant = 2;

        private void Var3_Click(object sender, EventArgs e) => SelectedVariant = 3;

        private void NextButton_Click(object sender, EventArgs e) => EnteredAnswer = WritePanel.Answer;

        private void Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                DialogResult = DialogResult.Abort;
            }
            
        }
    }
}
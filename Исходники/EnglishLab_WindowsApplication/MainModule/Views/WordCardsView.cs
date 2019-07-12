using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace MainModule.Views
{
    public partial class WordCardsView : UserControl, IWordCardsView
    {
        public event EventHandler NextClick;
        public event EventHandler PreviousClick;
        public event EventHandler UserKnowsClick;
        public event EventHandler PlayClick;

        public string Word { set => wordBox.Text = value; }
        public string Description { set => descriptionBox.Text = value; }
        public string Translation { set => translationBox.Text = value; }

        public WordCardsView()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
        }

        private void toMainView_Click(object sender, EventArgs e)
        {
            Panel containerPanel = Dashboard.Instance.viewPanel;

            containerPanel.Controls.Remove(this);
            containerPanel.Controls.Add(MainView.Instance);

            Dashboard.Instance.Text = Dashboard.HeaderText;
            Dashboard.Instance.Refresh();
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (PlayClick != null) PlayClick(this, EventArgs.Empty);
            SpeechSynthesizer speaker = new SpeechSynthesizer();


            speaker.SelectVoice("Microsoft Zira Desktop");

            //foreach (InstalledVoice voice in speaker.GetInstalledVoices())
            //{
            //    VoiceInfo info = voice.VoiceInfo;
            //    MessageBox.Show(" Voice Name: " + info.Name);
            //}
            speaker.SpeakAsync(wordBox.Text);
        }

        private void print_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            if (NextClick != null) NextClick(this, EventArgs.Empty);
        }

        private void userKnows_Click(object sender, EventArgs e)
        {
            if (UserKnowsClick != null) UserKnowsClick(this, EventArgs.Empty);
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (PreviousClick != null) PreviousClick(this, EventArgs.Empty);
        }

        private void WordCardsView_Load(object sender, EventArgs e)
        {
            if (NextClick != null) NextClick(this, EventArgs.Empty);
        }
    }
}

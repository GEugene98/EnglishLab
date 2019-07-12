using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Speech.Synthesis;
using WordSetManager;

namespace MainModule.Views
{
    public partial class WordTestView : UserControl
    {
        WordSet WordSet;
        Word CurrentWord;
        bool WordToTranslation;
        Button[] Variants;
        Color DColor;
        public event EventHandler Close;

        public WordTestView(object wordSet, bool wordToTranslation)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            WordSet = wordSet as WordSet;
            WordToTranslation = wordToTranslation;

            Variants = new Button[]
            {
                variant1,
                variant2,
                variant3,
                variant4
            };

            DColor = variant1.BackColor;

            LoadWord();
        }

        private void toMainView_Click(object sender, EventArgs e)
        {
            Panel containerPanel = Dashboard.Instance.viewPanel;

            if (Close != null) Close(this, EventArgs.Empty);

            containerPanel.Controls.Remove(this);
            containerPanel.Controls.Add(MainView.Instance);

            Dashboard.Instance.Text = Dashboard.HeaderText;
            Dashboard.Instance.Refresh();
        }

        private void Variant_MouseEnter(object sender, EventArgs e) => ((Button)sender).ForeColor = Color.White;

        private void Variant_MouseLeave(object sender, EventArgs e) => ((Button)sender).ForeColor = Color.Black;

        private void play_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speaker = new SpeechSynthesizer();
            speaker.SelectVoice("Microsoft Zira Desktop");
            speaker.SpeakAsync(wordBox.Text);
        }

        private void variant_Click(object sender, EventArgs e)
        {
            var variant = sender as Button;

            if (WordToTranslation)
            {
                if (variant.Text == CurrentWord.Translation)
                {
                    CurrentWord.Progress++;
                    LoadWord();
                }
                else
                    variant.BackColor = Color.Red;
            }
            else
            {
                if (variant.Text == CurrentWord.ToString())
                {
                    CurrentWord.Progress++;
                    LoadWord();
                }
                else
                    variant.BackColor = Color.Red;
            }
        }

        private void LoadWord()
        {
            for (int i = 0; i < Variants.Length; i++)
            {
                Variants[i].BackColor = DColor;
            }

            CurrentWord = WordSet.GetNextWordForLearning();

            if (WordToTranslation)
            {
                wordBox.Text = CurrentWord.ToString();
                descriptionBox.Text = CurrentWord.Description;

                do
                {
                    for (int i = 0; i < Variants.Length; i++)
                    {
                        Variants[i].Text = WordSet.GetRandomWordExcepting(CurrentWord).Translation;
                    }

                } while (

                   Variants[0].Text == Variants[1].Text ||
                   Variants[0].Text == Variants[2].Text ||
                   Variants[0].Text == Variants[3].Text ||

                   Variants[1].Text == Variants[0].Text ||
                   Variants[1].Text == Variants[2].Text ||
                   Variants[1].Text == Variants[3].Text ||

                   Variants[2].Text == Variants[0].Text ||
                   Variants[2].Text == Variants[1].Text ||
                   Variants[2].Text == Variants[3].Text ||

                   Variants[3].Text == Variants[0].Text ||
                   Variants[3].Text == Variants[1].Text ||
                   Variants[3].Text == Variants[2].Text
                   );

                Variants[(new Random()).Next(3)].Text = CurrentWord.Translation;
            }
            else
            {
                wordBox.Text = CurrentWord.Translation;
                descriptionBox.Text = "";

                do
                {
                    for (int i = 0; i < Variants.Length; i++)
                    {
                        Variants[i].Text = WordSet.GetRandomWordExcepting(CurrentWord).ToString();
                    }

                } while (

                   Variants[0].Text == Variants[1].Text ||
                   Variants[0].Text == Variants[2].Text ||
                   Variants[0].Text == Variants[3].Text ||

                   Variants[1].Text == Variants[0].Text ||
                   Variants[1].Text == Variants[2].Text ||
                   Variants[1].Text == Variants[3].Text ||

                   Variants[2].Text == Variants[0].Text ||
                   Variants[2].Text == Variants[1].Text ||
                   Variants[2].Text == Variants[3].Text ||

                   Variants[3].Text == Variants[0].Text ||
                   Variants[3].Text == Variants[1].Text ||
                   Variants[3].Text == Variants[2].Text
                   );

                Variants[(new Random()).Next(3)].Text = CurrentWord.ToString();
            }
        }
    }
}

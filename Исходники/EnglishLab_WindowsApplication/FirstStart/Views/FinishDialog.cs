using System;
using MetroFramework.Forms;
using FirstStart.Models;
using System.Diagnostics;

namespace FirstStart.Views
{
    public partial class FinishDialog : MetroForm
    {
        public FinishDialog(QuestionManager manager)
        {
            InitializeComponent();

            string
                message = "В среднем вами было верно выполнено {0}% заданий, что соответствует уровню {1}.\n"+
                "Нажмите кнопку \"Продолжить\", чтобы перейти к главному окну приложения.\nВпереди много интересного!";

            string totalLevel = manager.TotalLevel.ToString();

            level.Text = String.Format("Ваш уровень - {0}", totalLevel);
            levelInfo.Text = String.Format(message, manager.AveragePrecent, totalLevel);

            chart.Series[0].Points.AddXY("Аудирование", manager.RightListeningPrecent);
            chart.Series[0].Points.AddXY("Грамматика", manager.RightGrammarPrecent);
            chart.Series[0].Points.AddXY("Речь", manager.RightSpeakingPrecent);
            chart.Series[0].Points.AddXY("Письмо", manager.RightWritingPrecent);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

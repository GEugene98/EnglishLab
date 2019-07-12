using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStart.Views
{
    interface ITestView
    {
        Mode Mode { get; set; }
        int Progress { get; set; }
        int MaxCountQuestions { set; }
        string Status { set; }
        string Question { set; }
        string[] Variants { set; }

        int SelectedVariant { get; }
        string EnteredAnswer { get; }

        void SuccessFinish();

        event EventHandler FinishClick;
        event EventHandler SkipClick;
        event EventHandler VariantChosen;
        event EventHandler AnswerEntered;
    }
}

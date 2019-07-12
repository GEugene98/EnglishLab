using System;
using FirstStart.Views;
using FirstStart.Models;
using UserData;

namespace FirstStart.Presenters
{
    class TestPresenter
    {
        ITestView TestView;
        QuestionManager _QuestionManager;

        public TestPresenter(ITestView view, QuestionManager questionManager)
        {
            TestView = view;
            _QuestionManager = questionManager;

            TestView.AnswerEntered += TestView_AnswerEntered;
            TestView.VariantChosen += TestView_VariantChosen;
            TestView.SkipClick += TestView_SkipClick;
            TestView.FinishClick += TestView_FinishClick;

            TestView.MaxCountQuestions = _QuestionManager.CountQuestions;

            ShowNextQuestion();
        }

        private void TestView_FinishClick(object sender, EventArgs e) => TestView.SuccessFinish();

        private void TestView_SkipClick(object sender, EventArgs e) => ShowNextQuestion();

        private void TestView_VariantChosen(object sender, EventArgs e)
        {
            _QuestionManager.CheckAnswer(TestView.SelectedVariant);

            TestView.Status = _QuestionManager.RightGrammar.ToString();
            ShowNextQuestion();
        }

        private void TestView_AnswerEntered(object sender, EventArgs e)
        {
            _QuestionManager.CheckAnswer(TestView.EnteredAnswer);
            
            TestView.Status = _QuestionManager.RightGrammar.ToString();
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            try
            {
                Question question = _QuestionManager.GetNextQuestion();

                TestView.Mode = question.Mode;

                TestView.Question = question.TextQuestion;

                if (question.Mode == Mode.Choose)
                    TestView.Variants = question.Variants;

                TestView.Progress++;
                TestView.Status = String.Format("{0} ({1}/{2})", question.Skill.ToString(), TestView.Progress, _QuestionManager.CountQuestions);
            }
            catch
            {
                TestView.SuccessFinish();
            }            
        }
    }
}

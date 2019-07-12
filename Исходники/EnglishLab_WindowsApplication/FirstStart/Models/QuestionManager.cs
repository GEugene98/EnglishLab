using System;
using System.Collections.Generic;
using System.Xml.Linq;
using UserData;

namespace FirstStart.Models
{
    public class QuestionManager
    {
        private Question[] Questions;
        private Question ActiveQuestion;
        private int IndexNextQuestion;

        public int CountGrammar { get; private set; }
        public int CountListening { get; private set; }
        public int CountSpeaking { get; private set; }
        //private int CountReading;
        public int CountWriting { get; private set; }

        public int RightGrammar { get; private set; }
        public int RightListening { get; private set; }
        public int RightSpeaking { get; private set; }
        //private int RightReading;
        public int RightWriting { get; private set; }

        public float AveragePrecent
        {
            get
            {
                return (int)Math.Round(RightGrammarPrecent + RightListeningPrecent + RightSpeakingPrecent + RightWritingPrecent) / 4;
            }
        }

        public float RightGrammarPrecent
        {
            get
            {
                return ((float)RightGrammar / (float)CountGrammar) * 100;

            }
        }

        public float RightListeningPrecent
        {
            get
            {
                return ((float)RightListening / (float)CountListening) * 100;

            }
        }

        public float RightSpeakingPrecent
        {
            get
            {
                return ((float)RightSpeaking / (float)CountSpeaking) * 100;

            }
        }

        public float RightWritingPrecent
        {
            get
            {
                return ((float)RightWriting / (float)CountWriting) * 100;

            }
        }

        public Level TotalLevel
        {
            get
            {
                float average = AveragePrecent;

                if (average < 25)
                    return Level.Beginner;

                if (average >= 25 && average < 60)
                    return Level.Elementary;

                if (average >= 60 && average < 95)
                    return Level.Intermediate;

                if (average >= 95)
                    return Level.Advanced;

                return Level.Beginner;
            }
        }

        public int TotalRight
        {
            get
            {
                return RightGrammar + RightListening + RightSpeaking + RightWriting;
            }
        }

        public readonly int CountQuestions;

        public QuestionManager(string xmlDocumentText)
        {
            Questions = GetArrayQuestions(xmlDocumentText);
            CountQuestions = Questions.Length;
        }

        private Question[] GetArrayQuestions(string xmlDocumentText)
        {
            XDocument doc = XDocument.Parse(xmlDocumentText);

            List<Question> allQuestionsList = new List<Question>();

            List<Question> listening = GetListeningQuestions(doc);
            foreach (var item in listening)
                allQuestionsList.Add(item);

            List<Question> grammar = GetGrammarQuestions(doc);
            foreach (var item in grammar)
                allQuestionsList.Add(item);

            List<Question> speaking = GetSpeakingQuestions(doc);
            foreach (var item in speaking)
                allQuestionsList.Add(item);

            List<Question> writing = GetWritingQuestions(doc);
            foreach (var item in writing)
                allQuestionsList.Add(item);

            return allQuestionsList.ToArray();
        }

        private List<Question> GetGrammarQuestions(XDocument doc)
        {
            List<Question> questions = new List<Question>();

            DocumentMaker maker = new DocumentMaker("Resources/template.html", Skill.Grammar);

            foreach (XElement questionElement in doc.Element("questions").Elements("grammar"))
                foreach (XElement question in questionElement.Elements("qw"))
                {
                    XElement q = question.Element("q");

                    XElement @as = question.Element("as");

                    XAttribute right = q.Attribute("right");

                    XAttribute type = q.Attribute("type");

                    List<string> variants = new List<string>();

                    foreach (XElement variant in @as.Elements("a"))
                        variants.Add(variant.Value);

                    if (type.Value == "choose")
                        questions.Add(new Question(Skill.Grammar, maker.GetHTMLFromTextQuestion(q.Value), int.Parse(right.Value), variants.ToArray()));

                    if (type.Value == "answer")
                        questions.Add(new Question(Skill.Grammar, maker.GetHTMLFromTextQuestion(q.Value), variants.ToArray()));

                }
            CountGrammar = questions.Count;
            return questions;
        }

        private List<Question> GetListeningQuestions(XDocument doc)
        {
            List<Question> questions = new List<Question>();

            DocumentMaker maker = new DocumentMaker("Resources/template_video.html", Skill.Listening);

            foreach (XElement questionElement in doc.Element("questions").Elements("listening"))
                foreach (XElement question in questionElement.Elements("qw"))
                {
                    XElement q = question.Element("q");

                    XElement @as = question.Element("as");

                    XAttribute right = q.Attribute("right");

                    XAttribute type = q.Attribute("type");

                    List<string> variants = new List<string>();

                    foreach (XElement variant in @as.Elements("a"))
                        variants.Add(variant.Value);

                    if (type.Value == "choose")
                        questions.Add(new Question(Skill.Listening, maker.GetHTMLFromTextQuestion(q.Value), int.Parse(right.Value), variants.ToArray()));

                    if (type.Value == "answer")
                        questions.Add(new Question(Skill.Listening, maker.GetHTMLFromTextQuestion(q.Value), variants.ToArray()));

                }
            CountListening = questions.Count;
            return questions;
        }

        private List<Question> GetSpeakingQuestions(XDocument doc)
        {
            List<Question> questions = new List<Question>();

            DocumentMaker maker = new DocumentMaker("Resources/template_video.html", Skill.Speaking);

            foreach (XElement questionElement in doc.Element("questions").Elements("speaking"))
                foreach (XElement question in questionElement.Elements("qw"))
                {
                    XElement q = question.Element("q");

                    XElement @as = question.Element("as");

                    XAttribute right = q.Attribute("right");

                    XAttribute type = q.Attribute("type");

                    List<string> variants = new List<string>();

                    foreach (XElement variant in @as.Elements("a"))
                        variants.Add(variant.Value);

                    if (type.Value == "choose")
                        questions.Add(new Question(Skill.Speaking, maker.GetHTMLFromTextQuestion(q.Value), int.Parse(right.Value), variants.ToArray()));

                    if (type.Value == "answer")
                        questions.Add(new Question(Skill.Speaking, maker.GetHTMLFromTextQuestion(q.Value), variants.ToArray()));

                }
            CountSpeaking = questions.Count;
            return questions;
        }

        private List<Question> GetWritingQuestions(XDocument doc)
        {
            List<Question> questions = new List<Question>();

            DocumentMaker maker = new DocumentMaker("Resources/template.html", Skill.Writing);

            foreach (XElement questionElement in doc.Element("questions").Elements("writing"))
                foreach (XElement question in questionElement.Elements("qw"))
                {
                    XElement q = question.Element("q");

                    XElement @as = question.Element("as");

                    XAttribute right = q.Attribute("right");

                    XAttribute type = q.Attribute("type");

                    List<string> variants = new List<string>();

                    foreach (XElement variant in @as.Elements("a"))
                        variants.Add(variant.Value);

                    if (type.Value == "choose")
                        questions.Add(new Question(Skill.Writing, maker.GetHTMLFromTextQuestion(q.Value), int.Parse(right.Value), variants.ToArray()));

                    if (type.Value == "answer")
                        questions.Add(new Question(Skill.Writing, maker.GetHTMLFromTextQuestion(q.Value), variants.ToArray()));

                }
            CountWriting = questions.Count;
            return questions;
        }

        private void Increase(Skill skill)
        {
            switch (skill)
            {
                case Skill.Grammar:
                    RightGrammar++;
                    break;

                case Skill.Listening:
                    RightListening++;
                    break;

                //case Skill.Reading:
                //    RightReading++;
                //    break;

                case Skill.Speaking:
                    RightSpeaking++;
                    break;

                case Skill.Writing:
                    RightWriting++;
                    break;
            }
        }

        public void CheckAnswer(int variant)
        {
            if (variant == ActiveQuestion.IndexRight) Increase(ActiveQuestion.Skill);
        }

        public void CheckAnswer(string userAnswer)
        {
            userAnswer = userAnswer.ToLower().Trim();

            foreach (string possibleAnswer in ActiveQuestion.AllowableAnswers)
                if (userAnswer.Contains(possibleAnswer.ToLower().Trim())) Increase(ActiveQuestion.Skill);
        }

        public Question GetNextQuestion()
        {
            if (IndexNextQuestion >= Questions.Length)
            {
                //throw new Exception("Questions have been finished");

            }


            int indexThisQuestion = IndexNextQuestion;

            IndexNextQuestion++;

            ActiveQuestion = Questions[indexThisQuestion];

            return ActiveQuestion;
        }
    }
}
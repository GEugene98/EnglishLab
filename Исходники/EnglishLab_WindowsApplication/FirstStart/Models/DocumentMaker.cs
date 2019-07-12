using System;
using System.IO;

namespace FirstStart.Models
{
    class DocumentMaker
    {
        private string HTMLTemplate;
        private Skill SkillType;

        public DocumentMaker(string pathHtmlTemplate, Skill skillType)
        {
            HTMLTemplate = File.ReadAllText(pathHtmlTemplate);
            SkillType = skillType;
        }

        public string GetHTMLFromTextQuestion(string textQuestion)
        {
            switch (SkillType)
            {
                case Skill.Grammar:
                case Skill.Writing:
                    return GetHTMLForPicContent(textQuestion);
                case Skill.Listening:
                case Skill.Speaking:
                    return GetHTMLForVideoContent(textQuestion);
            }

            return null;
        }

        private string GetHTMLForPicContent(string textQuestion)
        {
            string picPath = "";

            for (int i = 0; i < textQuestion.Length; i++)
                if (textQuestion[i] == '@')
                {
                    picPath = textQuestion.Substring(i + 1);
                    textQuestion = textQuestion.Substring(0, i);
                    break;
                }

            if (picPath == "")
                picPath = "absence.png";

            string document = HTMLTemplate.Replace("PICTURE_PATH", (Environment.CurrentDirectory + "/Resources/" + picPath).Replace('\\', '/'));
            return document.Replace("QUESTION_TEXT", textQuestion);
        }

        private string GetHTMLForVideoContent(string textQuestion)
        {
            string mediaPath = "";

            for (int i = 0; i < textQuestion.Length; i++)
                if (textQuestion[i] == '@')
                {
                    mediaPath = textQuestion.Substring(i + 1);
                    textQuestion = textQuestion.Substring(0, i);
                    break;
                }

            string document = HTMLTemplate.Replace("VIDEO_PATH", (Environment.CurrentDirectory + "/Resources/" + mediaPath).Replace('\\', '/'));
            return document.Replace("QUESTION_TEXT", textQuestion);
        }
    }
}

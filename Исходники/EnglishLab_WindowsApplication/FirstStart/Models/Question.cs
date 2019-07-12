using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStart.Models
{
    public class Question
    {
        public string TextQuestion { get; private set; }
        public Mode Mode { get; private set; }
        public int IndexRight { get; private set; }
        public Skill Skill { get; private set; }
        
        public string[] Variants { get; private set; }
        public string[] AllowableAnswers { get; private set; }

        public Question(Skill skill, string textQuestion, int indexRight, string[] variants)
        {
            Skill = skill;
            TextQuestion = textQuestion;
            IndexRight = indexRight;
            Variants = variants;

            Mode = Mode.Choose;
        }

        public Question(Skill skill, string textQuestion, string[] allowableAnswers)
        {
            Skill = skill;
            TextQuestion = textQuestion;
            AllowableAnswers = allowableAnswers;

            Mode = Mode.Answer;
        }
    }
}

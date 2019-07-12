using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSetManager
{
    [Serializable]
    public class Word
    {
        private string Text;

        public string Translation { get; private set; }
        public string Description { get; private set; }

        private byte progress;
        public byte Progress
        {
            get => progress;

            set
            {
                if (value > 10)
                    throw new Exception("Progress cannot be over 10");

                progress = value;
            }
        }

        public bool IsLearnt { get => Progress == 10; }

        public Word(string text, string translation, string description)
        {
            Text = text;
            Translation = translation;
            Description = description;
        }

        public char[] GetSplittedWord() => Text.ToCharArray();

        public override string ToString() => Text;
    }
}

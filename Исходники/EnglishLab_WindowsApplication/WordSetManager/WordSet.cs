using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WordSetManager
{
    [Serializable]
    public class WordSet
    {
        private string Name;

        public Bitmap Picture { get; private set; }

        private List<Word> WordList;

        protected string CSVPath;

        public int CountWords { get => WordList.Count; }

        public int CountLearntWords
        {
            get
            {
                int sum = 0;

                foreach (Word word in WordList)
                {
                    if (word.IsLearnt)
                        sum++;
                }

                return sum;
            }
        }

        public WordSet(string name)
        {
            WordList = new List<Word>();
            //CurrentList = new Word[5];
            Name = name;
            r = new Random();
        }

        public WordSet(string name, string pathToImage) : this(name) => Picture = new Bitmap(Image.FromFile(pathToImage));

        public WordSet(string name, string pathToImage, string pathToCSV) : this(name, pathToImage) => CSVPath = pathToCSV;

        public void LoadFromCSV(string path)
        {
            string[] wordStrings = File.ReadAllLines(path);

            for (int i = 0; i < wordStrings.Length; i++)
            {
                string[] wordStr = wordStrings[i].Split(';');

                Word word = new Word(wordStr[0], wordStr[1], wordStr[2]);

                WordList.Add(word);
            }
        }

        public void Load() => LoadFromCSV(CSVPath);

        public void AddWord(string text, string translation, string description)
        {
            Word word = new Word(text, translation, description);

            WordList.Add(word);
        }

        public void AddWord(Word word) => WordList.Add(word);

        public void RemoveWord(Word word) => WordList.Remove(word);

        public DataTable GetDataTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Слово");
            dataTable.Columns.Add("Транскрипция");
            dataTable.Columns.Add("Перевод");
            dataTable.Columns.Add("Прогресс слова");

            foreach (Word word in WordList)
            {
                DataRow dataRow = dataTable.NewRow();

                dataRow[0] = word.ToString();
                dataRow[1] = word.Description;
                dataRow[2] = word.Translation;
                dataRow[3] = word.Progress;

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        public static List<WordSet> GetList(string csvDirectory)
        {
            DirectoryInfo directory = new DirectoryInfo(csvDirectory);

            List<WordSet> wordSetList = new List<WordSet>();

            foreach (FileInfo file in directory.GetFiles("*.csv"))
            {
                string
                    csv = file.FullName,
                    name = file.Name.Split('.')[0],
                    pic = Path.Combine(csvDirectory, "Pictures", file.Name.Split('.')[0] + ".png");

                wordSetList.Add(new WordSet(name, pic, csv));
            }

            return wordSetList;
        }

        public override string ToString() => Name;

        #region ForActivities

        private Queue<Word> Words;

        private int NextIndex = 0;
        private bool NextWordGotten;
        public Word GetNextWord()
        {
            if (NextIndex == WordList.Count)
                NextIndex = 0;

            var word = WordList[NextIndex];

            NextIndex++;
            NextWordGotten = true;

            return word;
        }

        private int PreviousIndex = -1;
        public Word GetPreviousWord()
        {
            if (PreviousIndex == -1)
            {
                PreviousIndex = WordList.Count - 1;
                return WordList[PreviousIndex];
            }

            if (NextWordGotten)
            {
                PreviousIndex = NextIndex - 2;
                NextWordGotten = false;
                return WordList[PreviousIndex];
            }

            var word = WordList[PreviousIndex];

            PreviousIndex--;
            NextIndex = PreviousIndex + 2;

            return word;
        }

        public Word GetNextWordForLearning()
        {
            if (Words == null || Words.Count == 0)
            {
                Words = new Queue<Word>();

                WordList[0].Progress = 1;
                WordList.Sort((a, b) => a.Progress.CompareTo(b.Progress));

                for (int i = 0; i < 5; i++)
                {
                    if (WordList[i].Progress < 10 && !Words.Contains(WordList[i]))
                        Words.Enqueue(WordList[i]);
                }
            }

            return Words.Dequeue();
        }
        Random r;
        public Word GetRandomWordExcepting(Word word)
        {

            //Word rndWord;

            //do
            //{
            return WordList[r.Next(WordList.Count - 1)];
            //}
            //while (rndWord == word);

            //return rndWord;
        }

        public void MakeWordLearnt(Word word)
        {
            word.Progress = 10;
        }

        #endregion
    }
}
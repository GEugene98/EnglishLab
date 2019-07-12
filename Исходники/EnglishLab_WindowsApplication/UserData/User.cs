using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using WordSetManager;

namespace UserData
{
    [Serializable]
    public class User
    {
        private string Name;

        public Level UserLevel { get; private set; }

        public List<WordSet> LearntSets { get; private set; }
        public List<WordSet> SetsOnLearning { get; private set; }
        public WordSet UserDictornary { get; private set; }

        private int CountLearntWordsFromRemovedSets;
        public int CountLearntWords
        {
            get
            {
                int sum = UserDictornary.CountLearntWords + CountLearntWordsFromRemovedSets;

                foreach (WordSet set in LearntSets)
                    sum += set.CountLearntWords;

                foreach (WordSet set in SetsOnLearning)
                    sum += set.CountLearntWords;

                return sum;
            }
        }
        public int CountSetsOnLearning
        {
            get
            {
                return SetsOnLearning.Count - 1;
            }
        }

        protected string Path = "UserInfo.dat";

        public User(string name, Level level)
        {
            Name = name;
            UserLevel = level;

            LearntSets = new List<WordSet>();
            SetsOnLearning = new List<WordSet>();
            UserDictornary = new WordSet("Мой словарь");
            SetsOnLearning.Add(UserDictornary);
        }

        public void Save(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                FileStream fstream = File.Open(path, FileMode.Create);

                BinaryFormatter binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(fstream, this);

                fstream.Close();
            }
            catch (Exception)
            {
                throw new Exception("It's not possible to create file");
            }

        }

        public void Save() => Save(this.Path);

        public void AddSetToLearn(object set)
        {
            (set as WordSet).Load();
            SetsOnLearning.Add(set as WordSet);
        }

        public void AddLearntSet(WordSet set) => LearntSets.Add(set);

        public void AddWordInUserDictiornary(string text, string translation, string description) => UserDictornary.AddWord(text, translation, description);

        public void RemoveSetFromLearning(object wordSet)
        {
            var set = wordSet as WordSet;

            //CountLearntWordsFromRemovedSets += set.CountLearntWords;

            SetsOnLearning.Remove(set);
        }

        public override string ToString() => Name;

        public static User GetUser(string path)
        {
            if (File.Exists(path))
            {
                User user;

                FileStream fstream = File.Open(path, FileMode.Open);

                BinaryFormatter binaryFormatter = new BinaryFormatter();

                user = (User)binaryFormatter.Deserialize(fstream);

                user.Path = path;

                fstream.Close();

                return user;
            }
            else throw new Exception("Cannot open file");
        }
    }
}

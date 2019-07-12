using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserData;
using WordSetManager;
using MainModule.Views;

namespace MainModule.Presenters
{
    public class MainViewPresenter
    {
        IMainView MainView;
        User ActiveUser;

        public MainViewPresenter(IMainView mainView)
        {
            MainView = mainView;
            ActiveUser = User.GetUser("UserInfo.dat");
            //ActiveUser = new User("ff", Level.Elementary);
            MainView.UserName = ActiveUser.ToString();         

            foreach (WordSet set in WordSet.GetList("WordSets"))
                mainView.AddOrUpdateWordSet(set, set.Picture, "allGroup");

            foreach (WordSet set in ActiveUser.SetsOnLearning)
            {
                if (set.ToString() == "Мой словарь") continue;
                mainView.AddOrUpdateWordSet(set, set.Picture, "onLearningGroup");
            }

            MainView.AddWord += MainView_AddWord;
            MainView.TakeSetToLearn += MainView_TakeSetToLearn;
            MainView.RemoveSetAtLearning += MainView_RemoveSetAtLearning;
            MainView.INeedToUpdate += MainView_INeedToUpdate;

            UpdateInfo();
        }

        private void MainView_INeedToUpdate(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void MainView_RemoveSetAtLearning(object sender, EventArgs e)
        {
            ActiveUser.RemoveSetFromLearning(MainView.SelectedWordSet);
            MainView.UpdateWordSet(MainView.SelectedWordSet, "allGroup");
            UpdateInfo();
        }

        private void MainView_TakeSetToLearn(object sender, EventArgs e)
        {
            ActiveUser.AddSetToLearn(MainView.SelectedWordSet);
            MainView.UpdateWordSet(MainView.SelectedWordSet, "onLearningGroup");
            UpdateInfo();
        }

        private void MainView_AddWord(object sender, EventArgs e)
        {
            ActiveUser.AddWordInUserDictiornary(MainView.Word, MainView.Translation, MainView.Transcription);
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            MainView.CountLearntWords = ActiveUser.CountLearntWords;
            MainView.UserVocabulary = ActiveUser.UserDictornary.GetDataTable();
            MainView.CountWordSetsOnLearning = ActiveUser.CountSetsOnLearning;
            MainView.WordSetsOnLearning = ActiveUser.SetsOnLearning;
            MainView.Level = ActiveUser.UserLevel.ToString();
            ActiveUser.Save();
        }
    }
}

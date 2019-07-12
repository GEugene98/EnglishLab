using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MainModule.Views
{
    public interface IMainView
    {
        #region Statistic

        string UserName { set; }
        string Level { set; }
        int CountLearntWords { set; }
        int CountWordSetsOnLearning { set; }

        int GoalPrecent { set; }
        string Goal { set; }

        #endregion

        #region Activities
        object GrammarActivities { set; }
        object ListeningActivities { set; }
        object PhrasesActivities { set; }
        object WordSetsOnLearning { set; }

        object SelectedTopic { get; }
        object SelectedListeningActivity { get; }
        object SlectedPhrasesActivity { get; }
        object SelectedWordSet { get; }

        event EventHandler GrammarActivitySelected;
        event EventHandler ListeningActivitySelected;
        event EventHandler PhrasesActivitySelected;
        #endregion

        #region Vocabulary
        //List<ListViewItem> WordSets { set; }
        void AddOrUpdateWordSet(object wordSet, Bitmap picture, string group);
        bool UpdateWordSet(object wordSet, string group);

        event EventHandler TakeSetToLearn;
        event EventHandler RemoveSetAtLearning;

        object UserVocabulary { set; }
        string Word { get; }
        string Transcription { get; }
        string Translation { get; }
        event EventHandler AddWord;
        event EventHandler RemoveWord;

        #endregion

        #region Grammar
        object GrammarTopics { set; }
        event EventHandler GrammarTopicSelected;
        #endregion

        #region TrainingMaterials
        //object TrainingMaterials { set; }
        event EventHandler TrainingMaterialSelected;
        #endregion

        event EventHandler INeedToUpdate;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MainModule.Views
{
    public partial class MainView : UserControl, IMainView
    {
        private static MainView MainViewControl;

        public static MainView Instance
        {
            get
            {
                if (MainViewControl == null)
                    MainViewControl = new MainView();

                return MainViewControl;
            }

        }

        private Panel ContainerPanel;

        private MainView()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            ContainerPanel = Dashboard.Instance.viewPanel;

            mainTabs.SelectedIndex = activitiesTabs.SelectedIndex = 0;

            //grammarActivitiesBox.Items[0] = "";
            //grammarActivitiesBox.Items[0] = "";
            //grammarActivitiesBox.Items[0] = "";
            //grammarActivitiesBox.Items[0] = "";
            //grammarActivitiesBox.Items[0] = "";
        }

        #region Implementation IMainView

        public string UserName
        {
            set
            {
                greetingMessage.Text = greetingMessage.Text.Replace("username", value);
                materialsMessage.Text = materialsMessage.Text.Replace("username", value);
            }
        }

        public string Level { get; set; }

        public int CountLearntWords { set => learnt.Text = value.ToString(); }
        public int CountWordSetsOnLearning { set => onLearning.Text = value.ToString(); }
        public int GoalPrecent { set => progress.Value = value; }
        public string Goal { set => goal.Text = value; }

        public object GrammarActivities { set => grammarActivitiesBox.DataSource = value; }
        public object ListeningActivities { set => listeningBox.DataSource = value; }
        public object PhrasesActivities { set => phrasesBox.DataSource = value; }
        public object WordSetsOnLearning
        {
            set
            {
                setsOnLearning.DataSource = null;
                setsOnLearning.DataSource = value;
            }
        }

        public object SelectedTopic => grammarActivitiesBox.SelectedItem;
        public object SelectedListeningActivity => listeningBox.SelectedItem;
        public object SlectedPhrasesActivity => phrasesBox.SelectedItem;
        public object SelectedWordSet { get; private set; }

        public object UserVocabulary { set => userWordsTable.DataSource = value; }

        public string Word { get; private set; }
        public string Transcription { get; private set; }
        public string Translation { get; private set; }

        public object GrammarTopics { set => grammarBox.DataSource = value; }
        //public object TrainingMaterials { set => materialsBox.DataSource = value; }

        public event EventHandler GrammarActivitySelected;
        public event EventHandler ListeningActivitySelected;
        public event EventHandler PhrasesActivitySelected;
        public event EventHandler TakeSetToLearn;
        public event EventHandler RemoveSetAtLearning;
        public event EventHandler AddWord;
        public event EventHandler RemoveWord;
        public event EventHandler GrammarTopicSelected;
        public event EventHandler TrainingMaterialSelected;
        public event EventHandler INeedToUpdate;

        public void AddOrUpdateWordSet(object wordSet, Bitmap picture, string group)
        {
            if (!UpdateWordSet(wordSet, group))
            {
                string name = wordSet.ToString();

                imageList.Images.Add(name, picture);

                ListViewItem item = new ListViewItem();
                item.Group = allSetsBox.Groups[group];
                item.Text = name;
                item.ImageKey = name;
                item.Tag = wordSet;

                allSetsBox.Items.Add(item);
            }
        }

        public bool UpdateWordSet(object wordSet, string group)
        {
            bool updated = false;

            foreach (ListViewItem listItem in allSetsBox.Items)
                if (listItem.Text == wordSet.ToString())
                {
                    listItem.Tag = wordSet;

                    if (listItem.Group.Name != group)
                    {
                        listItem.Group = allSetsBox.Groups[group];
                        updated = true;
                    }
                }

            return updated;
        }
        #endregion

        private void addWordBtn_Click(object sender, EventArgs e)
        {
            Word = (String.IsNullOrWhiteSpace(wordBox.Text)) ? null : wordBox.Text;
            Transcription = (String.IsNullOrWhiteSpace(transcriptionBox.Text)) ? null : transcriptionBox.Text;
            Translation = (String.IsNullOrWhiteSpace(translationBox.Text)) ? null : translationBox.Text;

            wordBox.Text = "Слово ";
            transcriptionBox.Text = "Транскрипция ";
            translationBox.Text = "Перевод ";

            if (AddWord != null) AddWord(this, EventArgs.Empty);
        }

        private void someBox_Enter(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;

            if (text == "Слово " || text == "Транскрипция " || text == "Перевод ")
                ((TextBox)sender).Clear();
        }


        private Presenters.WordCardsPresenter CardsPresenter;
        private void cardsTile_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Text = cardsTile.Text;
            Dashboard.Instance.Refresh();

            WordCardsView wordCardsView = new WordCardsView();
            CardsPresenter = new Presenters.WordCardsPresenter(wordCardsView, setsOnLearning.SelectedItem);

            ContainerPanel.Controls.Remove(this);
            ContainerPanel.Controls.Add(wordCardsView);
        }

        private void wtTile_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Text = wtTile.Text;
            Dashboard.Instance.Refresh();

            ContainerPanel.Controls.Remove(this);

            var wtw = new WordTestView(setsOnLearning.SelectedItem, true);

            wtw.Close += Wtw_Close; 


            ContainerPanel.Controls.Add(wtw);
        }

        private void Wtw_Close(object sender, EventArgs e)
        {
            if (INeedToUpdate != null) INeedToUpdate(this, EventArgs.Empty);
        }

        private void twTile_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Text = twTile.Text;
            Dashboard.Instance.Refresh();

            ContainerPanel.Controls.Remove(this);
            ContainerPanel.Controls.Add(new WordTestView(setsOnLearning.SelectedItem, false));
        }

        private void constructorTile_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Text = constructorTile.Text;
            Dashboard.Instance.Refresh();

            ContainerPanel.Controls.Remove(this);
            ContainerPanel.Controls.Add(new WordBuilderView());
        }

        private void userWordsTable_DataSourceChanged(object sender, EventArgs e)
        {
            userWordsTable.Sort(userWordsTable.Columns[3], ListSortDirection.Ascending);
        }

        private void allSetsBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (allSetsBox.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    var context = new ContextMenuStrip();
                    context.ShowImageMargin = false;

                    if (allSetsBox.SelectedItems[0].Group == allSetsBox.Groups["allGroup"])
                        context.Items.Add("Изучать");

                    if (allSetsBox.SelectedItems[0].Group == allSetsBox.Groups["onLearningGroup"])
                        context.Items.Add("Не изучать");

                    context.Click += Context_Click;

                    context.Show(Cursor.Position);
                }
            }
        }

        private void Context_Click(object sender, EventArgs e)
        {
            SelectedWordSet = allSetsBox.SelectedItems[0].Tag;

            var menu = sender as ContextMenuStrip;

            switch (menu.Items[0].Text)
            {
                case "Изучать": if (TakeSetToLearn != null) TakeSetToLearn(this, EventArgs.Empty); break;
                case "Не изучать": if (RemoveSetAtLearning != null) RemoveSetAtLearning(this, EventArgs.Empty); break;
            }
        }

        private void grammarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dashboard.Instance.Text = "Грамматика";
            Dashboard.Instance.Refresh();

            ContainerPanel.Controls.Remove(this);
            
            if (grammarBox.SelectedIndex == 0)
                ContainerPanel.Controls.Add(new DocViewer("1.rtf"));
            if (grammarBox.SelectedIndex == 1)
                ContainerPanel.Controls.Add(new DocViewer("2.rtf"));
            if (grammarBox.SelectedIndex == 2)
                ContainerPanel.Controls.Add(new DocViewer("3.rtf"));
            if (grammarBox.SelectedIndex == 3)
                ContainerPanel.Controls.Add(new DocViewer("4.rtf"));
            if (grammarBox.SelectedIndex == 4)
                ContainerPanel.Controls.Add(new DocViewer("5.rtf"));
            if (grammarActivitiesBox.SelectedIndex == 5)
                ContainerPanel.Controls.Add(new DocViewer("6.rtf"));

        }

        private void metroTile9_Click(object sender, EventArgs e) //lit
        {
            Dashboard.Instance.Text = "Литература";
            Dashboard.Instance.Refresh();

            ContainerPanel.Controls.Remove(this);
            ContainerPanel.Controls.Add(new DocViewer("lit.rtf"));
        }

        private void metroTile10_Click(object sender, EventArgs e) //sci
        {
            Dashboard.Instance.Text = "Наука";
            Dashboard.Instance.Refresh();

            ContainerPanel.Controls.Remove(this);
            ContainerPanel.Controls.Add(new DocViewer("sci.rtf"));
        }

        private void metroTile8_Click(object sender, EventArgs e) //ch
        {
            Dashboard.Instance.Text = "Для детей";
            Dashboard.Instance.Refresh();

            ContainerPanel.Controls.Remove(this);
            ContainerPanel.Controls.Add(new DocViewer("kids.rtf"));
        }

        private void metroTile7_Click(object sender, EventArgs e) // cul
        {
            Dashboard.Instance.Text = "Кулинария";
            Dashboard.Instance.Refresh();

            ContainerPanel.Controls.Remove(this);
            ContainerPanel.Controls.Add(new DocViewer("cooking.rtf"));
        }

        private void metroTile6_Click(object sender, EventArgs e) // talk
        {
            Dashboard.Instance.Text = "Болтовня по-английски";
            Dashboard.Instance.Refresh();

            ContainerPanel.Controls.Remove(this);
            ContainerPanel.Controls.Add(new DocViewer("talk.rtf"));
        }

        private void grammarActivitiesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dashboard.Instance.Text = "Упражнения";
            Dashboard.Instance.Refresh();

            ContainerPanel.Controls.Remove(this);

            if (grammarActivitiesBox.SelectedIndex == 0)
                ContainerPanel.Controls.Add(new DocViewer("ga1.rtf"));
            if (grammarActivitiesBox.SelectedIndex == 1)
                ContainerPanel.Controls.Add(new DocViewer("ga2.rtf"));
        }
    }
}

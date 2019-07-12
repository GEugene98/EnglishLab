using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainModule.Views;
using WordSetManager;

namespace MainModule.Presenters
{
    class WordCardsPresenter
    {
        private IWordCardsView CardsView;
        private WordSet WordSet;
        private Word CurrentWord;

        public WordCardsPresenter(IWordCardsView cardsView, object wordSet)
        {
            CardsView = cardsView;

            WordSet = wordSet as WordSet;

            CardsView.NextClick += CardsView_NextClick;
            CardsView.PreviousClick += CardsView_PreviousClick;
        }

        private void CardsView_PreviousClick(object sender, EventArgs e)
        {
            CurrentWord = WordSet.GetPreviousWord();
            CardsView.Word = CurrentWord.ToString();
            CardsView.Translation = CurrentWord.Translation;
            CardsView.Description = CurrentWord.Description;
        }

        private void CardsView_NextClick(object sender, EventArgs e)
        {
            CurrentWord = WordSet.GetNextWord();
            CardsView.Word = CurrentWord.ToString();
            CardsView.Translation = CurrentWord.Translation;
            CardsView.Description = CurrentWord.Description;
        }
    }
}

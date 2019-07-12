using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule.Views
{
    interface IWordCardsView
    {
        string Word { set; }
        string Description { set; }
        string Translation { set; }

        event EventHandler NextClick;
        event EventHandler PreviousClick;
        event EventHandler UserKnowsClick;
        event EventHandler PlayClick;
    }
}

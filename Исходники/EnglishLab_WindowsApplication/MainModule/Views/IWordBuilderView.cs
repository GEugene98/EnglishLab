using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModule.Views
{
    interface IWordBuilderView
    {
        string InjectableWord { get; set; }
        string Description { set; }
        List<string> PartsOfWord { set; }
        bool Correct { set; }

        event EventHandler WordEntered;
    }
}

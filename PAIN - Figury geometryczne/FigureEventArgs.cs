using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne
{
    public class FigureEventArgs : EventArgs
    {
        public Figure figure
        {
            get;
            set;
        }

        public FigureEventArgs(Figure fig)
        {
            figure = fig;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne
{
    public class Figures
    {
        public  event EventHandler<FigureEventArgs> NewFigureAddedEvent;
        public event EventHandler<FigureEventArgs> FigureModifiedEvent;
        public event EventHandler<FigureEventArgs> FigureDeletedEvent;

        public List<Figure> _Figures { get; private set; }

        public Figures()
        {
            _Figures = new List<Figure>();
        }

        public void Add(Figure figure)
        {
            _Figures.Add(figure);

            if (NewFigureAddedEvent != null)
                NewFigureAddedEvent(this, new FigureEventArgs(figure));
        }

        public void Delete(Figure fig)
        {
            _Figures.Remove(fig);
            if(FigureDeletedEvent != null)
                FigureDeletedEvent(this, new FigureEventArgs(fig));
        }

        public void Update(Figure prev, Figure newF)
        {
            int at = IndexByRef(prev);
            if (at < 0)
                return;

            _Figures[at] = newF;

            if (FigureModifiedEvent != null)
                FigureModifiedEvent(this, new FigureEventArgs(newF, prev));
        }

        public Figure ByName(string name)
        {
            Figure result = _Figures.Find(x => x.Label == name);

            return result;
        }

        public Figure ByRef(Figure fig)
        {

            int at = IndexByRef(fig);
            if (at < 0)
                return null;

            return _Figures[at];
        }

        public int IndexByRef(Figure fig)
        {
            int at = 0;

            foreach(Figure item in _Figures)
            {
                if (item == fig)
                    return at;

                at++;
            }

            return -1;
        }
    }
}

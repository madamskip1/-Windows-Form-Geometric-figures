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

        public void Update(Figure fig)
        {
            if (FigureModifiedEvent != null)
                FigureModifiedEvent(this, new FigureEventArgs(fig));
        }

    }
}

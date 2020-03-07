using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne
{
    class FiguresList
    {
        private List<Figure> _Figures;
        private static FiguresList _instance;
        public static FiguresList Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new FiguresList();
                    _instance._Figures = new List<Figure>();
                }

                return _instance;
            }
        }

        public List<Figure> Figures
        {
            get
            {
                return _Figures;
            }
        }

        public bool Add(Figure figure)
        {
            this._Figures.Add(figure);
            return true;
        }

        public bool Delete(Figure fig)
        {
            return _Figures.Remove(fig);
        }

        public void Update(Figure prev, Figure newF)
        {
            int at = IndexByRef(prev);
            if (at < 0)
                return;

            Figures[at] = newF;
        }

        public Figure ByName(string name)
        {
            Figure result = _Figures.Find(x => x.Label == name);

            return result;
        }

        public Figure ByRef(Figure fig)
        {
            int at = 0;
            foreach(Figure item in Figures)
            {
                if (item == fig)
                    break;

                at++;
            }

            
            return Figures[at];
        }

        public int IndexByRef(Figure fig)
        {
            int at = 0;

            foreach(Figure item in Figures)
            {
                if (item == fig)
                    return at;

                at++;
            }

            return -1;
        }
    }
}

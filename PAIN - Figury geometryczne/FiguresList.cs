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

        public bool add(Figure figure)
        {
            this._Figures.Add(figure);
            return true;
        }

        public bool delete(string name)
        {
            Figure result = byName(name);
            if (result == null)
                return false;

            return _Figures.Remove(result);
        }

        public bool delete(Figure fig)
        {
            return _Figures.Remove(fig);
        }

        public Figure byName(string name)
        {
            Figure result = _Figures.Find(x => x.Label == name);

            return result;
        }
    }
}

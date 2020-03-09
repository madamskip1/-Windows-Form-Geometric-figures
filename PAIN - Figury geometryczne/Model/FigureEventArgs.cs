﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne
{
    public class FigureEventArgs : EventArgs
    {
        public Figure Figure
        {
            get;
            set;
        }
        public Figure Previous
        {
            get;
            set;
        }

        public FigureEventArgs(Figure fig)
        {
            Figure = fig;
            Previous = null;
        }

        public FigureEventArgs(Figure fig, Figure prev)
        {
            Figure = fig;
            Previous = prev;
        }
    }
}
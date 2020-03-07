using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN___Figury_geometryczne
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FiguresList list = FiguresList.Instance;
            Figure fig1 = new Triangle();
            Figure fig2 = new Square();
            Figure fig3 = new Circle();

            fig1.Label = "Test1";
            fig1.Color = "#111111";
            fig1.Coords = new Point(1, 2);
            fig1.Area = 10;

            fig2.Label = "Test2";
            fig2.Color = "#222222";
            fig2.Coords = new Point(3, 4);
            fig2.Area = 20;

            fig3.Label = "Test3";
            fig3.Color = "#333333";
            fig3.Coords = new Point(5, 6);
            fig3.Area = 30;

            list.Add(fig1);
            list.Add(fig2);
            list.Add(fig3);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

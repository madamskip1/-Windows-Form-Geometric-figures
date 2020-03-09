using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN___Figury_geometryczne.Controller
{
    public class FiguresListViewController
    {
        private Figures figures;

        public void SetFigures(Figures figs)
        {
            figures = figs;
        }

        public void AddClicked()
        {
            AddDialog addDialog = new AddDialog();
            addDialog.SetController(this);
            addDialog.Show();
        }

        public void ModifyClicked(Figure fig)
        {
            ModifyDialog modifyDialog = new ModifyDialog(fig);
            modifyDialog.SetController(this);
            modifyDialog.Show();
        }

        public void DeleteClicked(Figure fig)
        {
            figures.Delete(fig);
        }

        public void AddFigure(Figure fig)
        {
            figures.Add(fig);

        }

        public void FigureModified(Figure figCur, Figure newFig)
        {
            if (newFig == null)
                newFig = figCur;

            figures.Update(figCur, newFig);
        }
    }
}

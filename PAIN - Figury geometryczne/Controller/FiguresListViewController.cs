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
            AddDialogController addDialogController = new AddDialogController();
            addDialogController.SetFigures(figures);
            addDialogController.RunModal();
            
        }

        public void ModifyClicked(Figure fig)
        {
            ModifyDialogController modifyDialogController = new ModifyDialogController();
            modifyDialogController.SetFigures(figures);
            modifyDialogController.SetFigure(fig);
            modifyDialogController.RunModal();
        }

        public void DeleteClicked(Figure fig)
        {
            figures.Delete(fig);
        }




    }
}

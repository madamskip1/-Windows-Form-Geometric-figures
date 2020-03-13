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

        // Add button clicked
        public void AddClicked()
        {
            AddModifyController addModifyController = new AddModifyController();
            addModifyController.SetFigures(figures);
            addModifyController.RunAddModal();
        }

        // Modify button or context menu clicked
        public void ModifyClicked(Figure fig)
        {
            AddModifyController addModifyController = new AddModifyController();
            addModifyController.SetFigures(figures);
            addModifyController.SetFigureToModify(fig);
            addModifyController.RunModifyModal();
        }

        // Delete button or context menu clicked
        public void DeleteClicked(Figure fig)
        {
            figures.Delete(fig);
        }

    }
}

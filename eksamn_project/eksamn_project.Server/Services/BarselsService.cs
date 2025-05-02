using eksamn_project.Server.Helpers;
using eksamn_project.Server.Models;
namespace eksamn_project.Server.Services
{
    public class BarselsService
    {
        private BarselsHelper _barselsHelper;
        public BarselsService(BarselsHelper barselsHelper) {
            _barselsHelper = barselsHelper;
        }
        public int CalculateAmountOfBarsel(BarselModel model) 
        {
            int amountOfWeeks = _barselsHelper.CalculateBarsel(model.RelationshipStatus,model.OverEnskomst,model.Arbejdsstatus,model.multiplechildren,model.singleChild);
            return amountOfWeeks; 
        }
    }
}

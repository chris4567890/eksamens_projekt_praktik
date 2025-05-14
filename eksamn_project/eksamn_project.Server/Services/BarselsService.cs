using eksamn_project.Server.Helpers;
using eksamn_project.Server.Models;
using eksamn_project.Server.Models.DTOs;
namespace eksamn_project.Server.Services
{
    public class BarselsService : IbarselsService
    {
        private BarselsHelper _barselsHelper;
        private OverenskomstDTO _OverenskomstDTO;
        private OverenskomstService _OverenskomstService;
        public BarselsService(BarselsHelper barselsHelper, OverenskomstDTO overenskomstDTO) {
            _barselsHelper = barselsHelper;
            _OverenskomstDTO = overenskomstDTO;
        }
        public int CalculateAmountOfBarselWithOvernskomst(BarselModel model, int week) 
        {
            
            int amountOfWeeks = _barselsHelper.CalculateBarsel(model.RelationshipStatus, week,model.Arbejdsstatus,model.multiplechildren,model.AmountOfChildren,model.Gender);
            return amountOfWeeks; 
        }

        public int CalculateAmountOfBarsel(BarselModel model) 
        {
            int amountOfWeeks = _barselsHelper.CalculateBarsel(model.RelationshipStatus,0, model.Arbejdsstatus, model.multiplechildren, model.AmountOfChildren, model.Gender);
            return amountOfWeeks;
        }

    }
}

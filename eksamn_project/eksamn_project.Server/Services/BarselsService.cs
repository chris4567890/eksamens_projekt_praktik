using eksamn_project.Server.Helpers;
using eksamn_project.Server.Models;
using eksamn_project.Server.Models.DTOs;
namespace eksamn_project.Server.Services
{
    public class BarselsService
    {
        private BarselsHelper _barselsHelper;
        private OverenskomstDTO _OverenskomstDTO;
        public BarselsService(BarselsHelper barselsHelper, OverenskomstDTO overenskomstDTO) {
            _barselsHelper = barselsHelper;
            _OverenskomstDTO = overenskomstDTO;
        }
        public int CalculateAmountOfBarsel(BarselModel model) 
        {
            int amountOfWeeks = _barselsHelper.CalculateBarsel(model.RelationshipStatus, _OverenskomstDTO.MaternityAmountByWeeks,model.Arbejdsstatus,model.multiplechildren,model.AmountOfChildren,model.Gender);
            return amountOfWeeks; 
        }
    }
}

using eksamn_project.Server.Models;
namespace eksamn_project.Server.Services
{
    public class BarselsService
    {
        public int CalculateAmountOfBarsel(BarselModel model) 
        {
            int amountOfWeeks = 0;
            if (model.RelationshipStatus == "single_mother")
            {
                if (model.Arbejdsstatus == "private")
                {
                    if (model.OverEnskomst == true && model.singleChild || model.multiplechildren)
                    {
                        amountOfWeeks = 36;
                    }
                    else if(model.singleChild || model.multiplechildren)
                    {
                        amountOfWeeks = 32;
                    }
                }
                else if (model.Arbejdsstatus == "offentlig")
                {
                    amountOfWeeks = 36;
                }
                
            }
            return amountOfWeeks; 
        }
    }
}

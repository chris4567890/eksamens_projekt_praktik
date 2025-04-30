namespace eksamn_project.Server.Services
{
    public class BarselsService
    {
        public int CalculateAmountOfBarsel(BarselsModel model) 
        {
            int amountOfWeeks = 0;
            if (model.Gender == "female")
            {
                if (model.Arbejdsstatus == "private")
                {
                    if (model.OverEnskomst == true)
                    {
                        amountOfWeeks = 36;
                    }
                    else 
                    {
                        amountOfWeeks = 14;
                    }
                }
                else if (model.arbejdsstatus == "offentlig")
                {
                    amountOfWeeks = 36;
                }
                
            }
            return amountOfWeeks; 
        }
    }
}

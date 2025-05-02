using eksamn_project.Server.Utility;
using System.Runtime.CompilerServices;

namespace eksamn_project.Server.Helpers
{
    public class BarselsHelper
    {
        public int CalculateBarsel(string Relationship,bool Overnskomst,string Arbejdsstatus,bool Multiplechildren,bool SingleChild)
        {
            SingleMomCalculator singleMomCalculator = new SingleMomCalculator();
            SingleFatherCalculator singleFatherCalculator = new SingleFatherCalculator();
            switch (Relationship)
            {
                case "single_mother":
                    return singleMomCalculator.calculate(Relationship,Overnskomst,Arbejdsstatus,Multiplechildren,SingleChild);    
                        
                case "single_father":
                    return singleFatherCalculator.calculate(Relationship, Overnskomst, Arbejdsstatus, Multiplechildren, SingleChild);
                    
                default:
                    return 0;
            }
        }
    }
}

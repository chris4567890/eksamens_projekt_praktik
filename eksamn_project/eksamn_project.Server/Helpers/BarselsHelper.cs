using eksamn_project.Server.Utility;
using System.Runtime.CompilerServices;

namespace eksamn_project.Server.Helpers
{
    public class BarselsHelper
    {
        public int CalculateBarsel(string Relationship,bool Overnskomst,string Arbejdsstatus,bool Multiplechildren,bool SingleChild, int AmountOfChildren)
        {
            SingleMomCalculator singleMomCalculator = new SingleMomCalculator();
            SingleFatherCalculator singleFatherCalculator = new SingleFatherCalculator();
            MotherFatherCalculator motherFatherCalculator = new MotherFatherCalculator();
            MomMomCalculator momMomCalculator = new MomMomCalculator();
            FatherFatherCalculator fatherFatherCalculator = new FatherFatherCalculator();
            switch (Relationship)
            {
                case "single_mother":
                    return singleMomCalculator.calculate(Overnskomst,Arbejdsstatus,Multiplechildren,SingleChild,AmountOfChildren);    
                case "single_father":
                    return singleFatherCalculator.calculate(Overnskomst, Arbejdsstatus, Multiplechildren, SingleChild,AmountOfChildren);
                case "mother_father":
                    return motherFatherCalculator.calculate(Overnskomst,Arbejdsstatus,Multiplechildren,SingleChild,AmountOfChildren);
                case "mother_mother":
                    return momMomCalculator.calculate(Overnskomst,Arbejdsstatus,Multiplechildren,SingleChild,AmountOfChildren);
                case "father_father":
                    return fatherFatherCalculator.calculate(Overnskomst,Arbejdsstatus,Multiplechildren,SingleChild,AmountOfChildren);
                default:
                    return 0;
            }
        }
    }
}

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
            MotherFatherCalculator motherFatherCalculator = new MotherFatherCalculator();
            MomMomCalculator momMomCalculator = new MomMomCalculator();
            FatherFatherCalculator fatherFatherCalculator = new FatherFatherCalculator();
            switch (Relationship)
            {
                case "single_mother":
                    return singleMomCalculator.calculate(Relationship,Overnskomst,Arbejdsstatus,Multiplechildren,SingleChild);    
                case "single_father":
                    return singleFatherCalculator.calculate(Relationship, Overnskomst, Arbejdsstatus, Multiplechildren, SingleChild);
                case "mother_father":
                    return motherFatherCalculator.calculate(Relationship,Overnskomst,Arbejdsstatus,Multiplechildren,SingleChild);
                case "mother_mother":
                    return momMomCalculator.calculate(Relationship,Overnskomst,Arbejdsstatus,Multiplechildren,SingleChild);
                case "father_father":
                    return fatherFatherCalculator.calculate(Relationship,Overnskomst,Arbejdsstatus,Multiplechildren,SingleChild);
                default:
                    return 0;
            }
        }
    }
}

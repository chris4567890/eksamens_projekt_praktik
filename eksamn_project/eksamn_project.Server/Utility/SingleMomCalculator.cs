using eksamn_project.Server.Models;

namespace eksamn_project.Server.Utility
{
    public class SingleMomCalculator
    {
        public int calculate(int Overnskomst, string Arbejdsstatus)
        {
            if (Overnskomst !=0 && Arbejdsstatus == "offentlig")
            {
                return 22+Overnskomst;
            }

            else if (Overnskomst == null && Arbejdsstatus == "offentlig")
            {
                return 36;
            }

            else if (Overnskomst != 0 && Arbejdsstatus == "privat")
            {
                return 14 + Overnskomst;
            }

            else if (Overnskomst == 0 && Arbejdsstatus == "privat")
            {
                return 14;
            }

            else
            {
                return 14;
            }
        }
    }
}

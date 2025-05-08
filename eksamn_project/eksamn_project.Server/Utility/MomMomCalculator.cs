namespace eksamn_project.Server.Utility
{
    public class MomMomCalculator
    {
        public int calculate(int Overnskomst, string Arbejdsstatus)
        {
            if (Overnskomst != 0 && Arbejdsstatus == "offentlig")
            {

                return 22+Overnskomst;
            }
            else if (Overnskomst != 0 && Arbejdsstatus == "privat")
            {
                return 22+Overnskomst;
            }
            else
            {
                return 14;
            }
        }
    }
}

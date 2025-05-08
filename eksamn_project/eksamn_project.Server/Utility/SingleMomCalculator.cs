namespace eksamn_project.Server.Utility
{
    public class SingleMomCalculator
    {
        public int calculate(int Overnskomst, string Arbejdsstatus)
        {
            if (Overnskomst !=null && Arbejdsstatus == "offentlig")
            {
                return 36;
            }
            else if (Overnskomst != null && Arbejdsstatus == "privat")
            {
                return 14+Overnskomst;
            }
            else
            {
                return 14;
            }
        }
    }
}

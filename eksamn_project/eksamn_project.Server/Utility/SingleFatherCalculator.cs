namespace eksamn_project.Server.Utility
{
    public class SingleFatherCalculator
    {
        public int calculate(int Overnskomst, string Arbejdsstatus)
        {
            if (Overnskomst != null && Arbejdsstatus == "offentlig")
            {

                return 22 + Overnskomst;
            }
            else if (Overnskomst != null && Arbejdsstatus == "privat")
            {
                return 22 + Overnskomst;
            }
            else
            {
                return 22;
            }
        }
    }
}

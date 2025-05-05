namespace eksamn_project.Server.Utility
{
    public class SingleMomCalculator
    {
        public int calculate(string Relationship, bool Overnskomst, string Arbejdsstatus, bool Multiplechildren, bool SingleChild)
        {
            if (Overnskomst && Arbejdsstatus == "offentlig")
            {
                return 36;
            }
            else if (Overnskomst && Arbejdsstatus == "privat")
            {
                return 36;
            }
            else
            {
                return 14;
            }
        }
    }
}

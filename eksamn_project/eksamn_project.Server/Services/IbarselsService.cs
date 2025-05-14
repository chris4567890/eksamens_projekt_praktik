using eksamn_project.Server.Models;

namespace eksamn_project.Server.Services
{
    public interface IbarselsService
    {
        public int CalculateAmountOfBarselWithOvernskomst(BarselModel model, int week);
        public int CalculateAmountOfBarsel(BarselModel model);
    }
}

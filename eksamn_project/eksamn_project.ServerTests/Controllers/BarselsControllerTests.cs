using Microsoft.VisualStudio.TestTools.UnitTesting;
using eksamn_project.Server.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eksamn_project.Server.Models;
using eksamn_project.Server.Services;
using eksamn_project.Server.Helpers;
using Moq;
using eksamn_project.Server.Models.DTOs;
namespace eksamn_project.Server.Controllers.Tests
{
    [TestClass()]
    public class BarselsControllerTests
    {
        [TestMethod()]
        public void PostTest()
        {
            var model = new BarselModel
            {
                Gender = "female",
                multiplechildren = false,
                RelationshipStatus = "single_mother",
                Arbejdsstatus = "offentlig",
                OverEnskomst = "ok25",
                AmountOfChildren = 1
            };
            var overenskomst = new Models.DTOs.OverenskomstDTO
            {
                Name = "ok25",
                Gender = model.Gender,
                MaternityAmountByWeeks = 14
            };
            /*BarselsHelper barselsHelper = new BarselsHelper();
            BarselsService barselsService = new BarselsService(barselsHelper,overenskomst);
            */
            /*var mockService = new Mock<IoverenskomstService>(); 
            mockService.Setup(m => m.GetOvernsKomstByName("ok25")).ReturnsAsync(overenskomst);
            var mockService2 = new Mock<IbarselsService>();
            mockService2.Setup(m =>m.CalculateAmountOfBarselWithOvernskomst(model,overenskomst.MaternityAmountByWeeks));
            BarselsController barselsController = new BarselsController(mockService,mockService2);
            var result = barselsController.Post(model);
            Assert.IsNotNull(result);*/
        }
    }
}
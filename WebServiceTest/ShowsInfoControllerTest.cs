using _9Digital_web_service.Controllers;
using _9Digital_web_service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _9Digital_web_service.test
{
    [TestClass]
    public class ShowsInfoControllerTest
    {
        [TestMethod]
        public void TestAPIShowInfoIsNull()
        {
            //arrange
            var controller = new ShowsInfoController();
            controller.ControllerContext = new ControllerContext();
            controller.ControllerContext.HttpContext = new DefaultHttpContext();
            var response = controller.ControllerContext.HttpContext.Response;
            //act
            ShowsInfo showsInfo = null;
            var result = controller.API(showsInfo);
            //assert

            Assert.AreEqual(400, response.StatusCode);
            Assert.IsInstanceOfType(result, typeof(JsonResult));
        }

        [TestMethod]
        public void TestAPIShowInfoIsNotNull()
        {
            //arrange
            var controller = new ShowsInfoController();
           
            ShowsInfo showsInfo = new ShowsInfo
            {
                Payload = new ShowInfo[]
                {
                    new ShowInfo
                    {
                       Image = new Image
                        {
                          ShowImage = "test"
                        },
                        Slug = "test",
                        Title = "test",
                        Drm = true,
                        EpisodeCount = 1
                    }
                }
            };

            //act
            var filterResult = controller.API(showsInfo);
            Assert.IsInstanceOfType(filterResult, typeof(JsonResult));
        }
    }

}

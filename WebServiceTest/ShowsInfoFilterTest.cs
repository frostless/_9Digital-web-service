using _9Digital_web_service.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace WebServiceTest
{
    [TestClass]
    public class ShowsInfoTest
    {
        [TestMethod]
        public void ShowsInfoShouldReturnEmptyListWhenPayLoadIsEmpty()
        {
            //arrange
            ShowsInfo showsInfo = new ShowsInfo
            {
                Payload = Enumerable.Empty<ShowInfo>(),
            };

            //act
            var filterResult = showsInfo.Filter();

            //assertion
            Assert.IsTrue(filterResult.Count == 0);
        }
        [TestMethod]
        public void ShowsInfoShouldNotReturnEmptyListWhenPayLoadIsNotEmpty()
        {
            //arrange
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
            var filterResult = showsInfo.Filter();

            //assertion
            Assert.IsTrue(filterResult.Count > 0);
        }
    }
}

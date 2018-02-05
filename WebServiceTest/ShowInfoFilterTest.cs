using _9Digital_web_service.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebServiceTest
{
    [TestClass]
    public class ShowInfoTest
    {
        [TestMethod]
        public void ShowInfoShouldReturnReponseWhenDrmTrueAndEpisodeCountGreaterZeroTest()
        {
            //arrange
            ShowInfo showInfo = new ShowInfo
            {  Image = new Image
               {
                ShowImage = "test"
               },
                Slug = "test",
                Title = "test",
                Drm = true,
                EpisodeCount = 1
            };

            //act
            var filterResult = showInfo.Filter();

            //assertion
            Assert.IsInstanceOfType(filterResult, typeof(Response));
        }
        [TestMethod]
        public void ShowInfoShouldReturnNullWhenDrmFalseTest()
        {
            //arrange
            ShowInfo showInfo = new ShowInfo
            {
                Image = new Image
                {
                    ShowImage = "test"
                },
                Slug = "test",
                Title = "test",
                Drm = false,
                EpisodeCount = 0
            };

           
            //act
            Response filterResult = showInfo.Filter();
          
            //assertion
            Assert.IsNull(filterResult);


        }

        [TestMethod]
        public void ShowInfoShouldReturnNullWhenEpisodeCountZeroTest()
        {
            //arrange
            ShowInfo showInfo = new ShowInfo
            {
                Image = new Image
                {
                    ShowImage = "test"
                },
                Slug = "test",
                Title = "test",
                Drm = true,
                EpisodeCount = 0
            };


            //act
            Response filterResult = showInfo.Filter();

            //assertion
            Assert.IsNull(filterResult);


        }

        [TestMethod]
        public void ShowInfoShouldReturnNullWhenEpisodeCountZeroAndDrmFalseTest()
        {
            //arrange
            ShowInfo showInfo = new ShowInfo
            {
                Image = new Image
                {
                    ShowImage = "test"
                },
                Slug = "test",
                Title = "test",
                Drm = false,
                EpisodeCount = 0
            };

            //act
            Response filterResult = showInfo.Filter();

            //assertion
            Assert.IsNull(filterResult);

        }

    }
}

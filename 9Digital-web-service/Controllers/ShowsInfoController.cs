using System.Collections.Generic;
using _9Digital_web_service.Models;
using Microsoft.AspNetCore.Mvc;


namespace _9Digital_web_service.Controllers
{
    [Route("api/[controller]")]
    public class ShowsInfoController :Controller
    {
        /// <summary>
        /// This action accepts showsInfo object type, check if the Json convertion 
        /// was successfult,if it was not, return a 400 error code with error message,
        /// otherwise return the filtered Json response
        /// </summary>
        /// <param name="showsInfo">showsInfo object received from the request</param>
        /// <returns>400 with error msg if failed, or filtered Json response if successful</returns>
        [HttpPost]
        public IActionResult API([FromBody]ShowsInfo showsInfo)
        {
            
            if (showsInfo == null)
            {
                Response.StatusCode = 400;
                return Json(new { error = "Could not decode request: JSON parsing failed" });
            }

            IList<Response> responses = showsInfo.Filter();
            var responsesToReturn = new { response = responses };
            return Json(responsesToReturn);
            
        }

    }
}

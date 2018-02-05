using _9Digital_web_service.Interfaces;
using System.Collections.Generic;

namespace _9Digital_web_service.Models
{
    public class ShowsInfo : IFilterable<IList<Response>>
    {
        public IEnumerable<ShowInfo> Payload { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public int TotalRecords { get; set; }

        public IList<Response> Filter()
        {
            IList<Response> responses = new List<Response>();

            foreach (ShowInfo showInfo in Payload)
            {
                var filterResult = showInfo.Filter();
                if (filterResult != null) responses.Add(filterResult);
            }
            return responses;

        }

    }
}

using RssReader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.ViewModels
{
    public class FakeHelper : IHelper
    {
        public List<CD> GetCDs()
        {
            List<CD> cDs = new List<CD>();

            cDs.Add(new CD()
            {
                Title = "This is long title so designer can test the long title at the time of designing the UI and understand the issues",
                Artist = "Bhavin Patel"
            });

            cDs.Add(new CD()
            {
                Title = "",
                Artist = "Testing Title Empty"
            });

            return cDs;
        }
    }
}

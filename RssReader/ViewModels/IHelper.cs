using RssReader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.ViewModels
{
    public interface IHelper
    {
        List<CD> GetCDs();
    }
}

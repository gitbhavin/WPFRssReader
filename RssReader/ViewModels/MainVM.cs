using RssReader.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader.ViewModels
{
   public  class MainVM
    {
        public ObservableCollection<CD> CdItems { get; set; }

        public MainVM()
        {
            CdItems = new ObservableCollection<CD>();

            ReadItems();
        }

        private void ReadItems()
        {
            List<CD> cds = new List<CD>();

            cds = Helper.GetCDs();
            CdItems.Clear();
            foreach(var cd in cds)
            {
                CdItems.Add(cd);
            }
        } 
    }
}

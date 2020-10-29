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

        IHelper _iHelper;

        public MainVM(IHelper iHelper)
        {
            this._iHelper = iHelper;
            CdItems = new ObservableCollection<CD>();

            ReadItems();
        }

        private void ReadItems()
        {
            List<CD> cds = new List<CD>();

            // without Dependancy Container
            //IHelper helper = new FakeHelper();
            //cds = helper.GetCDs();

            cds = _iHelper.GetCDs();
            CdItems.Clear();
            foreach(var cd in cds)
            {
                CdItems.Add(cd);
            }
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RssReader.Models
{
    [XmlRoot(ElementName = "CD")]
    public class CD
    {
        [XmlElement(ElementName = "TITLE")]
        public string Title { get; set; }

        [XmlElement(ElementName = "ARTIST")]
        public string Artist { get; set; }

        [XmlElement(ElementName = "COUNTRY")]
        public string Coutry { get; set; }

        [XmlElement(ElementName = "COMPANY")]
        public string Compney { get; set; }

        private string price;
        [XmlElement(ElementName = "PRICE")]
        public string Price
        {
            get { return price; }
            set
            {
                price = value;
                PriceRate = System.Convert.ToDouble(price);
            }
        }

        public double PriceRate { get; set; }

        [XmlElement(ElementName = "YEAR")]
        public int Year { get; set; }

    }
    [XmlRoot(ElementName = "CATALOG")]
    public class W3schoolXml
    {
        [XmlElement(ElementName = "CD")]
        public List<CD> Cd { get; set; }

    }



}

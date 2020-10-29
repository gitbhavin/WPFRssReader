using RssReader.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RssReader.ViewModels
{
    public class Helper
    {
        public static List<CD> GetCDs()
        {
            List<CD> listCDs = new List<CD>();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(W3schoolXml));
            using(WebClient client=new WebClient())
            {
                string xml = Encoding.Default.GetString(client.DownloadData("http://www-db.deis.unibo.it/courses/TW/DOCS/w3schools/xml/cd_catalog.xml"));

                using (Stream reader = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
                {
                    W3schoolXml blog = (W3schoolXml)xmlSerializer.Deserialize(reader);

                    listCDs = blog.Cd;
                }
            }

            return listCDs;
        }
    }
}

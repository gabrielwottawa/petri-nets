using PetriNets.Controller.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace PetriNets.Controller.Xml
{
    public class XmlFilePetriNet
    {
        private string filePath;
        private List<string> placeIds = new();
        private List<string> transitionIds = new();

        public PetriNet PetriNet { get; private set; }

        public XmlFilePetriNet(string filePath)
        {
            this.filePath = filePath;
            PetriNet = new PetriNet();
        }

        public void Load()
        {
            using (var reader = new StreamReader(filePath))
            {
                var document = new XmlDocument();
                document.Load(reader);
                createPlaces(document);
            }
        }

        private void createPlaces(XmlDocument document)
        {
            var places = document.GetElementsByTagName("place");
            for (var i = 0; i < places.Count; i++)
            {
                var place = places.Item(i);
                if (place != null)
                {    
                    var id = Regex.Match((place["id"]?.InnerText ?? ""), @"\d+").Value;
                    var convertedId = Convert.ToInt32(id);
                    var tokens = Convert.ToInt32(place["tokens"]?.InnerText ?? "0");
                    PetriNet.CreatePlace(convertedId, tokens);
                }
            }
        }
    }
}

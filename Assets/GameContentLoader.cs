namespace GameLog
{
    using UnityEngine;
    using System.Collections.Generic;
    using System.Xml;
    using System.Linq;
    using System.Xml.Linq;

    public class GameContentLoader : MonoBehaviour
    {
        public XmlDocument doc;
        XDocument xdoc;

        public List<string> games;

        // Start is called before the first frame update
        void Start()
        {
            doc = new XmlDocument();
            doc.Load("Assets/Resources/XMLFiles/gamedata.xml");
            games = new List<string>();

            XmlNodeList nList = doc.SelectNodes("/response/results/game/name");
            XmlNodeList list2 = doc.SelectNodes("/response/results/game");

            foreach (XmlNode node in nList)
            {
                games.Add(node.InnerText);
                Debug.Log(list2.Count);
            }

            //xdoc = XDocument.Load("Assets/Resources/XMLFiles/gamedata.xml");
            //XElement root = xdoc.Root;
            ////var games = root.Attributes("results").ToArray();
            //games = root.Descendants().ToArray();


            //Debug.Log(xdoc.Descendants().Count());
            


        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}

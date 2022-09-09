namespace GameLog
{
    using UnityEngine;
    using System.Collections.Generic;
    using System.Xml;

    public class BaseLibraryContentLoader : MonoBehaviour
    {
        public XmlDocument doc;

        public List<string> games;

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
            }         
        }
    }

    public class GameInfo2
    {
        public string gameTitle;
        public string gameDescription;

    }
}

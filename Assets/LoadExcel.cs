//---------------------------------------------------------------------------------------
//  THIRD-PARTY RESOURCE, CREDITS TO:
//      JesseeEtzler: https://www.youtube.com/watch?v=C37C2yCUlCM&ab_channel=JesseEtzler
//      CSVReader: https://pastebin.com/7XCA2UDD
//---------------------------------------------------------------------------------------
namespace CSVGameDataLoader
{
    using System.Collections.Generic;
    using UnityEngine;

    public class LoadExcel : MonoBehaviour
    {
        public Game blankGame;
        public List<Game> GameDatabase = new List<Game>();

        public void Awake()
        {
            LoadGameData();
        }

        public void LoadGameData()
        {
            GameDatabase.Clear();

            List<Dictionary<string, object>> data = CSVReader.Read("GameDatabase");
            for (var i = 0; i < data.Count; i++)
            {
                int id = int.Parse(data[i]["id"].ToString(), System.Globalization.NumberStyles.Integer);
                string title = data[i]["title"].ToString();
                string description = data[i]["description"].ToString();
                string developers = data[i]["developers"].ToString();
                string platforms = data[i]["platforms"].ToString();
                string state = data[i]["state"].ToString();

                AddGame(id, title, description, developers, platforms, state);
            }
        }

        public void AddGame(int id, string title, string description, string developers, string platforms, string state)
        {
            Game tempGame = new Game(blankGame);

            tempGame.id = id;
            tempGame.title = title;
            tempGame.description = description;
            tempGame.developers = developers;
            tempGame.platforms = platforms;
            tempGame.state = state;

            GameDatabase.Add(tempGame);
        }

        public int ReturnIndexID()
        {
            return GameDatabase.Count + 1;
        }
    }
}

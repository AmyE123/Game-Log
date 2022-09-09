//---------------------------------------------------------------------------------------
//  THIRD-PARTY RESOURCE, CREDITS TO:
//      JesseeEtzler: https://www.youtube.com/watch?v=C37C2yCUlCM&ab_channel=JesseEtzler
//      CSVReader: https://pastebin.com/7XCA2UDD
//---------------------------------------------------------------------------------------
namespace CSVGameDataLoader
{
    [System.Serializable]
    public class Game
    {
        public int id;
        public string title;
        public string description;
        public string developers;
        public string platforms;
        public string state;

        public Game(Game item)
        {
            id = item.id;
            title = item.title;
            description = item.description;
            developers = item.developers;
            platforms = item.platforms;
            state = item.state;
        }
    }
}
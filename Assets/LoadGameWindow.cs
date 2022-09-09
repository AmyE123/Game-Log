//---------------------------------------------------------------------------------------
//  THIRD-PARTY RESOURCE, CREDITS TO:
//      JesseeEtzler: https://www.youtube.com/watch?v=C37C2yCUlCM&ab_channel=JesseEtzler
//      CSVReader: https://pastebin.com/7XCA2UDD
//---------------------------------------------------------------------------------------
namespace CSVGameDataLoader
{
    using UnityEngine;
    using UnityEditor;
    using Unity.VisualScripting;

    public class LoadGameWindow : EditorWindow
    {
        public enum State { Library, InProgress, Completed }

        #region TempVars
        private string gameTitle = "Mario Kart 8";
        private string description = "Mario Kart 8 is a kart racing game developed and published by Nintendo, and first released for the Wii U in May 2014. It retains Mario Kart series game mechanics, where players control Mario franchise characters in kart racing, collecting a variety of items to hinder opponents or gain advantages in the race.";
        private string developers = "Nintendo";
        private string platforms = "Nintendo Switch, Wii U";
        private State state = State.Library;
        #endregion

        [MenuItem("Tools/LoadGame")]
        public static void ShowWindow()
        {
            GetWindow<LoadGameWindow>("LoadGameWindow");
        }

        private void OnGUI()
        {
            LoadExcel loadExcel = GameObject.Find("Manager").GetComponent<LoadExcel>();

            GUILayout.Label("Create Game", EditorStyles.boldLabel);
            gameTitle = EditorGUILayout.TextField("Game Title: ", gameTitle);
            description = EditorGUILayout.TextField("Description: ", description);
            developers = EditorGUILayout.TextField("Developers: ", developers);
            platforms = EditorGUILayout.TextField("Platforms: ", platforms);
            state = (State)EditorGUILayout.EnumFlagsField("State: ", state);

            if (GUILayout.Button("Game Create"))
            {
                CreateGame(loadExcel);              
            }

            GUILayout.Label("Reload Game Database", EditorStyles.boldLabel);
            if (GUILayout.Button("Reload Games"))
            {
                loadExcel.LoadGameData();
            }
        }

        private void CreateGame(LoadExcel loadExcel)
        {
            loadExcel.AddGame(loadExcel.ReturnIndexID(), gameTitle, description, developers, platforms, state.ToString());
            GameObject game = GameObject.CreatePrimitive(PrimitiveType.Cube);
            game.transform.position = new Vector3(0, 0, 0);
        }
    }
}
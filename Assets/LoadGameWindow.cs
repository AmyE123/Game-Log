//---------------------------------------------------------------------------------------
//  THIRD-PARTY RESOURCE, CREDITS TO:
//      JesseeEtzler: https://www.youtube.com/watch?v=C37C2yCUlCM&ab_channel=JesseEtzler
//      CSVReader: https://pastebin.com/7XCA2UDD
//---------------------------------------------------------------------------------------
namespace CSVGameDataLoader
{
    using UnityEngine;
    using UnityEditor;

    public class LoadGameWindow : EditorWindow
    {
        [MenuItem("Tools/LoadGame")]
        public static void ShowWindow()
        {
            GetWindow<LoadGameWindow>("LoadGameWindow");
        }

        private void OnGUI()
        {
            GUILayout.Label("Create Game", EditorStyles.boldLabel);
            if (GUILayout.Button("Game Create"))
            {
                CreateGame();
            }

            GUILayout.Label("Reload Game Database", EditorStyles.boldLabel);
            if (GUILayout.Button("Reload Games"))
            {
                GameObject.Find("Manager").GetComponent<LoadExcel>().LoadGameData();
            }
        }

        private void CreateGame()
        {
            GameObject game = GameObject.CreatePrimitive(PrimitiveType.Cube);
            game.transform.position = new Vector3(0, 0, 0);
        }
    }
}
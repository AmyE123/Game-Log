namespace GameLog
{
    using UnityEngine;
    using CSVGameDataLoader;
    using System.Collections.Generic;

    public class Manager : MonoBehaviour
    {
        #region CSVLoader
        private LoadExcel _loadExcel;
        #endregion

        #region GameData
        private List<Game> _allGames = new List<Game>();

        [SerializeField]
        private List<Game> _libraryGames = new List<Game>();

        [SerializeField]
        private List<Game> _inProgressGames = new List<Game>();

        [SerializeField]
        private List<Game> _completedGames = new List<Game>();
        #endregion

        private bool _isGameInfoCollapsed;
        private bool _isDataLoaded;

        [Header("Components")]
        public GameInfo GameInfo;

        [Header("Game Tab Components")]
        public GameObject GameItemPrefab;
        public Transform LibraryArea;
        public Transform InProgressArea;
        public Transform CompletedArea;

        public bool IsGameInfoCollapsed
        {
            get { return _isGameInfoCollapsed; }
            set { _isGameInfoCollapsed = value; }
        }

        private void Awake()
        {
            InitializeValues();
        }

        private void InitializeValues()
        {
            _isGameInfoCollapsed = true;
            _loadExcel = FindObjectOfType<LoadExcel>();
            _allGames = _loadExcel.GameDatabase;
            _isDataLoaded = true;

            if (_isDataLoaded)
            {
                FillFields();
            }
        }

        private void FillFields()
        {
            foreach (Game game in _allGames)
            {
                if (game.state == "Library")
                {
                    PopulateGameList(_libraryGames, game, LibraryArea);
                }
                if (game.state == "InProgress")
                {
                    PopulateGameList(_inProgressGames, game, InProgressArea);
                }
                if (game.state == "Completed")
                {
                    PopulateGameList(_completedGames, game, CompletedArea);
                }
            }
        }

        private void PopulateGameList(List<Game> list, Game game, Transform tab)
        {
            list.Add(game);
            foreach (Game g in list)
            {
                var gameItem = Instantiate(GameItemPrefab, tab);
                var content = gameItem.GetComponent<GameContent>();
                content.Manager = this;
                content.Game = g;
            }
        }
    }
}


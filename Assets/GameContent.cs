namespace GameLog
{
    using CSVGameDataLoader;
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    public class GameContent : MonoBehaviour
    {
        [SerializeField]
        private Manager _manager;

        [SerializeField]
        private Game _game;

        [SerializeField]
        private Image _icon;

        [SerializeField]
        private TextMeshProUGUI _title;

        [SerializeField]
        private TextMeshProUGUI _tag;

        public Manager Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }

        public Game Game
        {
            get { return _game; }
            set { _game = value; }
        }

        public void Start()
        {
            _title.text = Game.title;
        }

        public void OnClicked()
        {
            _manager.GameInfo.Toggle(_manager.IsGameInfoCollapsed, Game);            
        }
    }
}

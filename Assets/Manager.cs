namespace GameLog
{
    using UnityEngine;

    public class Manager : MonoBehaviour
    {
        private bool _isGameInfoCollapsed;

        [Header("Components")]
        public GameInfo GameInfo;

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
        }
    }
}


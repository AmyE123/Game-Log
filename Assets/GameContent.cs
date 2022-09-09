namespace GameLog
{
    using UnityEngine;

    public class GameContent : MonoBehaviour
    {
        [SerializeField]
        private Manager _manager;

        public void OnClicked()
        {
            _manager.GameInfo.Toggle(_manager.IsGameInfoCollapsed);            
        }
    }
}

namespace GameLog
{
    using UnityEngine;

    public class GameInfo : MonoBehaviour
    {
        [SerializeField]
        private RectTransform rectTransform;

        [SerializeField]
        private RectTransform arrowRectTransform;

        [SerializeField]
        private Manager _manager;

        [SerializeField]
        [Tooltip("IDX 0 = collapsed, IDX 1 = not collapsed")]
        private Vector3[] collapseVectors;

        public void OnArrowClicked()
        {
            Toggle(_manager.IsGameInfoCollapsed);
            RotateArrow();

        }

        private void RotateArrow()
        {
            if (_manager.IsGameInfoCollapsed)
            {
                arrowRectTransform.rotation = Quaternion.Euler(0, 0, -180);
            }
            else
            {
                arrowRectTransform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }

        public void Toggle(bool IsCollapsed)
        {
            ToggleCollapseAnim(IsCollapsed);
            _manager.IsGameInfoCollapsed = !_manager.IsGameInfoCollapsed;
            RotateArrow();
        }

        private void ToggleCollapseAnim(bool IsCollapsed)
        {
            if (IsCollapsed)
            {
                rectTransform.anchoredPosition = collapseVectors[1];
            }
            else
            {
                rectTransform.anchoredPosition = collapseVectors[0];
            }
        }

        private void FillInfo()
        {
            
        }
    }
}
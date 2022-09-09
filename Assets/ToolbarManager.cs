namespace GameLog
{
    using UnityEngine;

    public class ToolbarManager : MonoBehaviour
    {
        public GameObject _inProgressContainer;
        public GameObject _completedContainer;
        public GameObject _libraryContainer;

        public void InProgressBtn()
        {
            _inProgressContainer.SetActive(true);
            _completedContainer.SetActive(false);
            _libraryContainer.SetActive(false);
        }

        public void CompletedBtn()
        {
            _inProgressContainer.SetActive(false);
            _completedContainer.SetActive(true);
            _libraryContainer.SetActive(false);
        }

        public void LibraryButton()
        {
            _inProgressContainer.SetActive(false);
            _completedContainer.SetActive(false);
            _libraryContainer.SetActive(true);
        }
    }
}
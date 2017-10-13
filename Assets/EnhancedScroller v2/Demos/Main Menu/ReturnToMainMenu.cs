using UnityEngine;
using System.Collections;

namespace EnhancedScrollerDemos.MainMenu
{
    public class ReturnToMainMenu : MonoBehaviour
    {
        public void ReturnToMainMenuButton_OnClick()
        {
            Application.LoadLevel("MainMenu");
        }
    }
}
using UnityEngine;
using System.Collections;

namespace EnhancedScollerDemos.MainMenu
{
    public class MainMenu : MonoBehaviour
    {
        public void SceneButton_OnClick(string sceneName)
        {
            Application.LoadLevel(sceneName);
        }
    }
}
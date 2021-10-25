using UnityEngine;
using UnityEngine.SceneManagement;

namespace KartGame.UI
{
    public class LoadSceneButton : MonoBehaviour
    {
        [Tooltip("What is the name of the scene we want to load when clicking the button?")]
        public string[] SceneNames;

        public void LoadTargetScene() 
        {
            if (SceneNames.Length == 1)
            {
                SceneManager.LoadSceneAsync(SceneNames[0]);
            }
            else if (SceneNames.Length > 1)
            {
                SceneManager.LoadSceneAsync(SceneNames[0]);

                for (int index=1; index < SceneNames.Length;index++)
                {
                    SceneManager.LoadSceneAsync(SceneNames[index], LoadSceneMode.Additive);
                }
            }
        }
    }
}

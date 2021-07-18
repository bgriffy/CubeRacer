using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        var activeScene = SceneManager.GetActiveScene();
        var activeSceneBuildIndex = activeScene.buildIndex;
        SceneManager.LoadScene(activeSceneBuildIndex + 1); 
    }
}

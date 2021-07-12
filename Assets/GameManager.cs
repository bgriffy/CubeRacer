using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    private bool _gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject failedLevelUIPane;

   public void EndGame()
    {
        if (_gameHasEnded) return;
        _gameHasEnded = true;
        Invoke("Restart", restartDelay);
    }

    public void Restart()
    {
        var currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    public void CompleteLevel()
    {
        Debug.Log("Level1 complete!!!");
        completeLevelUI.SetActive(true);
    }
}

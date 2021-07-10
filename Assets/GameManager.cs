using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    private bool _gameHasEnded = false;
    public float restartDelay = 1f;

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
}

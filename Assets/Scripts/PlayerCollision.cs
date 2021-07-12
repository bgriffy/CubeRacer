using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject failedLevelUI;
    public float failedRestartDelay = 0.5f;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log($"Collider tag: {collisionInfo.collider.tag}");
            playerMovement.enabled = false;
            var tmpGameManager = FindObjectOfType<GameManager>();
            tmpGameManager.EndGame();
            ShowLevelFailedUI();
        }
    }

    private void ShowLevelFailedUI()
    {
        failedLevelUI.SetActive(true);
    }
    
}

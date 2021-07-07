using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement; 

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log($"Collider tag: {collisionInfo.collider.tag}");
            playerMovement.enabled = false;
        }
    }
    
}

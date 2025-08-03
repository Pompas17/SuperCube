using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Vector3 offset;
        
    void Update()
    {
        transform.position = Object.FindFirstObjectByType<PlayerMovement>().rb.position + offset;
    }
}

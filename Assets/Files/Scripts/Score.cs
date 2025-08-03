using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    
    
    void Update()
    {
        //scoreText.text = player.position.z.ToString("0");
        scoreText.text = Object.FindFirstObjectByType<PlayerMovement>().rb.position.z.ToString("0");
    }
    
}

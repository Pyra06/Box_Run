using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public PlayerMovement movement;
    public Text scorePlayer;
    //public Text score;

    void Update()
    {
        scorePlayer.text = player.position.z.ToString("0");
        if (movement.enabled == false || rb.position.y < -1f)
        {
            scorePlayer.text = "Game Over" + "\n" + player.position.z.ToString("0");
        };
    }
}

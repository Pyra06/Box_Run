using UnityEngine;

public class TPPCameraView : MonoBehaviour
{
    public Transform player;
    public Vector3 TPPLoc;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + TPPLoc;
    }
}

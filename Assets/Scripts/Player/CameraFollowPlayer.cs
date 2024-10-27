using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
            player = GameObject.FindWithTag("CameraFollow").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position;
    }
}

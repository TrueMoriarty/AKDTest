using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Movement
    [SerializeField]
    private float moveSpeed = 10.0f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        // Get input values for movement
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Time.deltaTime * moveSpeed;

        move = move.normalized;
        Debug.Log(move);

        // Calculate movement and apply force

        rb.MovePosition(move);
        //rb.AddRelativeForce(move);
    }
}

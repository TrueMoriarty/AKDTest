using UnityEngine;

public class PlayerCameraMovement : MonoBehaviour
{
    // Camera Rotation
    private float mouseX = 0;
    private float mouseY = 0;

    [SerializeField]
    private float tilteAnge = 200.0f;

    public Transform playerOrientation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        if (playerOrientation == null)
            playerOrientation = GameObject.FindWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        mouseX += Input.GetAxisRaw("Mouse X") * tilteAnge * Time.deltaTime;
        mouseY += -(Input.GetAxisRaw("Mouse Y") * tilteAnge * Time.deltaTime);

        mouseY = Mathf.Clamp(mouseY, -90f, 90f);

        transform.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        playerOrientation.rotation = Quaternion.Euler(0, mouseX, 0);
    }
}

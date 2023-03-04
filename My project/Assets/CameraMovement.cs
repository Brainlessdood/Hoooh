using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    private Transform playerCameraTransform;
    private Transform camTransform;

    public float sensitivity = 4000.0f;
    private float xRotation = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerCameraTransform = Player.playerCameraTransform;
        camTransform = GetComponent<Transform>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;// * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;// * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        playerCameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Player.playerTransform.Rotate(Vector3.up * mouseX);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public static Transform playerTransform;
    public static Transform playerCameraTransform;

    private Rigidbody rigidBody;

    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
        playerCameraTransform = playerTransform.Find("CameraPosition").GetComponent<Transform>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float forward = Input.GetAxis("Vertical") * speed;
        float strafe = Input.GetAxis("Horizontal") * speed;

        rigidBody.velocity = Vector3.zero;
        rigidBody.velocity += playerTransform.forward * forward;
        rigidBody.velocity += playerTransform.right * strafe;
    }
}

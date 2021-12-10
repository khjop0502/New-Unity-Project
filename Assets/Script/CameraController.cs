using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Rigidbody CameraRigidbody;
    public float speed = 8f;


    void Start()
    {
        CameraRigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        CameraRigidbody.velocity = newVelocity;
    }

}

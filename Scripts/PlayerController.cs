using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal"); //Get player input
        verticalInput = Input.GetAxis("Vertical"); //Get player input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput); //move vehicle forward
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput); //rotate vehicle
    }
}

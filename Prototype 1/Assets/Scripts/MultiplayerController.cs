using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerController : MonoBehaviour
{
    [Range(1, 2)]
    public int playerNumber = 1;
    private float velocity = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + playerNumber);
        verticalInput = Input.GetAxis("Vertical" + playerNumber);

        //move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * velocity * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}

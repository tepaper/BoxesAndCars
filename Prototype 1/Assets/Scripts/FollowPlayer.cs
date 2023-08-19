using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 5, -7);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;

        if (Input.GetKey(KeyCode.Alpha1))
        { 
            offset = new Vector3(0, 5, -7);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            offset = new Vector3(-0.5f, 1.8f, 1.5f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float horInput;
    public float speed = 10.0f;
    public float xRange = 10;

    public Collider player;
    void Start()
    {
        player.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        // keep player in bounds

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // move player on horizontal input
        horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horInput * Time.deltaTime * speed);

        // get spacebar input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Perform Attack 
            player.isTrigger = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Perform Attack 
            player.isTrigger = false;
        }

    }
}

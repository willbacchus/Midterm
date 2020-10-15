using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBounds : MonoBehaviour
{
    // COLLISIONS
   
   
    
   
    public float botBound = -50;
    public float upSpeed = 50;
    public float downSpeed = 50;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
      if (transform.position.z < botBound)
        {
            
            TextUpdate textcollision = GameObject.FindObjectOfType<TextUpdate>();
            textcollision.Fail();
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
       
        TextUpdate textcollision = GameObject.FindObjectOfType<TextUpdate>();
        PlayerController player = GameObject.FindObjectOfType<PlayerController>();
        if (gameObject.tag == "PowerUp")
        {
            textcollision.Success();
            player.speed = player.speed + upSpeed;
            Destroy(gameObject);
        }
       else if (gameObject.tag == "PowerDown")
        {
            textcollision.Success();
            player.speed = player.speed - downSpeed;
            Destroy(gameObject);
        }
        else if (gameObject.tag == "SmallBall")
        {
            textcollision.Success2();
            Destroy(gameObject);
        }
        else 
        {
            textcollision.Success();
            Destroy(gameObject);
        }


    }
}

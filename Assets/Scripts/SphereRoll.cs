using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRoll : MonoBehaviour
{
    void Awake()
    {
        PlayerStartingPosition();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerStartingPosition()
    {
        // transform.position = new Vector3(0, 1, 0);
        // transform.rotation = Quaternion.Euler(0,0,0);
    }
    
    void PlayerMovement()
    {
        //transform.position += Vector3.forward * (speed * Time.deltaTime);
        transform.Translate(0,0,(20*Time.deltaTime));

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Debug.LogError("Trigger DDetected");
        }
        
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Trigger")
        {
            Debug.LogError("COllision DDetected");
        }
        
        if (other.collider.CompareTag("Obstacle"))
        {
            Destroy(this.gameObject);
            Debug.LogError("Collison Occur");
        }
    }
}

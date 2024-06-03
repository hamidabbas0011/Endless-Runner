using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Control();
    }

    void Control()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-100 * Time.deltaTime,0,0);
        }if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(100 * Time.deltaTime,0,0);
        }if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,100 * Time.deltaTime);
        }if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,0,-100 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Respawn"))
        {
            
            Debug.LogError("Collision Detected");
        }
    }
}

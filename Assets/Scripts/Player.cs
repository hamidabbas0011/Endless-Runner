using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float _speed = 2.0f;
    [SerializeField] private GameObject pathPrefab;
    [SerializeField] private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerStartingPosition();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerStartingPosition()
    {
        transform.position = new Vector3(0, 0.11f, 0);
        transform.rotation = Quaternion.Euler(0,0,0);
    }
    
    void PlayerMovement()
    {
        
        
        //transform.position += Vector3.forward * (speed * Time.deltaTime);
        transform.Translate(0,0,(_speed*Time.deltaTime));

        if (Input.GetKeyDown(KeyCode.D) && transform.position.x <=1)
        {
            transform.Translate(Vector3.right * 2);
        }

        if (Input.GetKeyDown(KeyCode.A) && transform.position.x>=-1)
        {
            transform.Translate(Vector3.left * 2);
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Destroy(other.transform.parent.gameObject,3);
            _speed=_speed+1;
            Debug.Log(_speed);
            if (_speed>10)
            {
                animator.SetTrigger("speedUp");
            }
            if (_speed >40)
            {
                _speed = 40;
            }
            Debug.Log("Triggered by: " + other.gameObject.name);
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            //Destroy(this.gameObject);
            Debug.Log("Collision Occur");
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class Path : MonoBehaviour
{
    [SerializeField] private GameObject pathPrefab;
    [SerializeField] private int lastPosZ = 60;
    private bool _createPath = false;
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (_createPath == false)
        {
            _createPath = true;
            StartCoroutine(PathCreator());
        }
    }


    IEnumerator PathCreator()
    {
        Instantiate(pathPrefab, new Vector3(0,0,lastPosZ), Quaternion.identity);
        lastPosZ += 20;
        yield return new WaitForSeconds(1);
        _createPath = false;
    }
    
}

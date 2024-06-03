using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pathPrefab;
    [SerializeField] private GameObject[] enemyPrefab;
    [SerializeField] private GameObject enemyParent;
    [SerializeField] private int lastPosZ = 60;
    
    private bool _createPath = false;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    void Update()
    {
        if (_createPath == false)
        {
            _createPath = true;
            StartCoroutine(PathCreator());
            StartCoroutine(SpawnEnemy());
        }

        

    }
    
    
    //------------------------------------------Path Creation------------------------------------------//
    IEnumerator PathCreator()
    {
        Instantiate(pathPrefab, new Vector3(0,0,lastPosZ), Quaternion.identity);
        lastPosZ += 20;
        yield return new WaitForSeconds(1);
        _createPath = false;
    }
    
    
    //------------------------------------------Enemy Spawn------------------------------------------//
    
    IEnumerator SpawnEnemy()
    {
        var y = Random.Range(0,3);
        GameObject g;
        if (y==0)
        {
            g = Instantiate(enemyPrefab[y], new Vector3(0, 1,lastPosZ), Quaternion.identity);
        }
        else
        {
            g = Instantiate(enemyPrefab[y], new Vector3(Random.Range(-2,3), 1,lastPosZ + y), Quaternion.identity);
        }
        g.transform.parent = enemyParent.transform;
        yield return new WaitForSeconds(1);
        _createPath = false;
    }
}

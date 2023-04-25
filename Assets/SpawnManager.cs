using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;
    float randomHeight = 0.5f; 
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnPipes", 2.0f, 3.0f);
       //Generates new pipes at an interval///
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PipeSpawn()
    { 
       Instantiate( pipePrefab, new Vector2(2, Random.Range( 10f, 10f)), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipes;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("PipeSpawn", 1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PipeSpawn()
    { 
       Instantiate( pipes, new Vector2(10, Random.Range( 100f, 100f)), Quaternion.identity);
    }
}

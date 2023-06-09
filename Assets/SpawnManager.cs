using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Pipes;
    Bird birdscript;
    float randomHeight = 0.5f; 
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("PipeSpawn", 2.0f, 3.0f);
       birdscript = GameObject.Find("Bird").GetComponent<Bird>();
       //Generates new pipes at an interval///
    }

    // Update is called once per frame
    void Update()
    {
      if(birdscript.isAlive == false)
      {
         CancelInvoke();
      }
    }

    void PipeSpawn()
    { 
       Instantiate( Pipes, new Vector2(2, Random.Range( -randomHeight, randomHeight)), Quaternion.identity);
    }
}

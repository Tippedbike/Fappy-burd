using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapnManager : MonoBehaviour
{
    public GameObject Pipe
    // Start is called before the first frame update
    void Start()
    {
       InvokerRepeating("PipeSpwan");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PipeSpwan()
    { 
       Instantiate( Pipe, new Vector2(10, Random.Range( 100f, 100f)), Quaternion.indentity);
    }
}

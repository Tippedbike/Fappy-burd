using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //Moves pipes to left
       transform.Translate(Vector2.left * Time.deltaTime * speed);
       //Destroys pipes off the sreen
       if  (transform.position.magnitude > 20f)
       {
          Destroy(gameObject);
       }
    }
}

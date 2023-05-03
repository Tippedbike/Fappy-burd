using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    Rigidbody2D bird;
    int score = 0;
    public Text scoreUI; //Score//
    public bool isAlive; //checks if bird's heart is beating//

    // Start is called before the first frame update
    void Start()
    {

        bird = GetComponent<Rigidbody2D>();
        //Gives bird heart//
        isAlive = true;

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space) && isAlive)
       {
        bird.AddForce(new Vector2(0,1) * 450);
       } 
       //bird cracksa redbull a flies// 
    }
    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.CompareTag("Points")) 
      {
        //Increases score by 1//
        score = score +1;

        scoreUI.text = score.ToString();
      }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
      isAlive = false;
      //bird overdosed upon touching a wall//
    }
}

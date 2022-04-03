using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDog : MonoBehaviour

{
    public Canvas gameOverMenu;
    public Canvas startMenu;
    public GameObject postman;
    public GameObject dog;
    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 //Just hit another collider 2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("onCollisionEnter");
        gameOverMenu.enabled = true;
        postman.GetComponent<Animator>().ResetTrigger("Active");
        postman.GetComponent<Animator>().SetTrigger("Idle");
        postman.GetComponent<Rigidbody2D>().velocity = new UnityEngine.Vector2(0,0);

        dog.GetComponent<Animator>().ResetTrigger("Active");
        dog.GetComponent<Animator>().SetTrigger("Idle");
        dog.GetComponent<Rigidbody2D>().velocity = new UnityEngine.Vector2(0,0);

    }

    //Hitting a collider 2D
    private void OnCollisionStay2D(Collision2D collision)
    {
    //Do something
    }

    //Just stop hitting a collider 2D
    private void OnCollisionExit2D(Collision2D collision)
    {
    //Do something
    }
}

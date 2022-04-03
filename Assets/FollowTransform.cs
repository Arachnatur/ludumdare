using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransform : MonoBehaviour
{
    private Animator animator;
    public Rigidbody2D followRigidBody2D;
    public GameObject postman;
    public float dogSpeed;
    private bool isDogSpeedSet = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.RightArrow)) {
            if (animator != null) {
                animator.ResetTrigger("Idle");
                animator.SetTrigger("Active");
            }
            // transform.Translate(movement);
            
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    void FixedUpdate() {
        // Debug.Log("Postman actual speed " + followRigidBody2D.velocity.x);
        // Debug.Log("Postman default speed " + postman.GetComponent<Postman>().defaultSpeed.x);
        if (!isDogSpeedSet && followRigidBody2D.velocity.x > 0) {
            Vector2 dogSpeedUpdate = postman.GetComponent<Postman>().defaultSpeed * Time.deltaTime * dogSpeed;
            Debug.Log("Postman velocity" + followRigidBody2D.velocity);
            Debug.Log("DogSpeed update" + dogSpeedUpdate);
                this.GetComponent<Rigidbody2D>().velocity = dogSpeedUpdate;
                Debug.Log("Dog speed: " + this.GetComponent<Rigidbody2D>().velocity);
                isDogSpeedSet = true;
        }

        
    }
}

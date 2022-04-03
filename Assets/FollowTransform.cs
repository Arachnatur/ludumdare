using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransform : MonoBehaviour
{
    private Animator animator;
    public Rigidbody2D followRigidBody2D;
    public float dogSpeed;
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
        if (Input.GetKeyUp(KeyCode.RightArrow)) {
            if(animator != null) {
                animator.ResetTrigger("Active");
                animator.SetTrigger("Idle");
            }
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    void FixedUpdate() {
        Vector2 dogSpeedUpdate = followRigidBody2D.velocity * dogSpeed;
        
        if (dogSpeedUpdate.x > 0) {
            this.GetComponent<Rigidbody2D>().velocity = dogSpeedUpdate;
        }
        
    }
}

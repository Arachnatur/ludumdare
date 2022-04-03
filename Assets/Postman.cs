using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postman : MonoBehaviour
{
    private Animator animator;
    public float speed = 200f;
    public Canvas startCanvas;
    public Vector2 defaultSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        startCanvas.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
     

        if (Input.GetKey(KeyCode.RightArrow)) {
            if (animator != null) {
                animator.ResetTrigger("Idle");
                animator.SetTrigger("Active");
            }
            float inputX = Input.GetAxis("Horizontal");
            Vector2 movementSpeed = new Vector2(speed * inputX * Time.deltaTime, 0);
            GetComponent<Rigidbody2D>().velocity = movementSpeed;
            // transform.Translate(movement);
            if(startCanvas.enabled) {
                startCanvas.enabled = false;
            }
            
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)) {
            if(animator != null) {
                animator.ResetTrigger("Active");
                animator.SetTrigger("Idle");
            }
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }

    }
}

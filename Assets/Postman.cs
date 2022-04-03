using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Postman : MonoBehaviour
{
    private Animator animator;
    public float speed = 50f;
    public Animator dogAnimator;
    public Canvas startCanvas;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        startCanvas.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
     

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            if (animator != null) {
                animator.ResetTrigger("Idle");
                animator.SetTrigger("Active");
            }
            float inputX = Input.GetAxis("Horizontal");
            float inputY = Input.GetAxis("Vertical");
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed * inputX * Time.deltaTime, 0);
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

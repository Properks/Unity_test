using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts_for_X : MonoBehaviour
{
    private Rigidbody myRigid;
    [SerializeField] private GameObject field;
    private Vector3 first_position;

    private Animator animator;
    [SerializeField] private float movespeed;
    private bool ismove;
    // Start is called before the first frame update
    void Start() {
        myRigid = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        first_position = this.transform.position;
    }

    // Update is called once per frame
    void Update() {
        float dirX = Input.GetAxisRaw("Horizontal"); // If you input <-, ->, a, d, return 1. If not, return -1;
        float dirZ = Input.GetAxisRaw("Vertical"); // If you input uparrow, downarrow, w, s, return 1. If not, return -1;
        
        Vector3 direction = new Vector3(dirX, 0, dirZ);
        // Movement
        ismove = false;
        if (direction != Vector3.zero) {
            ismove = true;
            this.transform.Translate(direction.normalized * movespeed * Time.deltaTime); // normalized, if direction is (1, 0, 1), move to diagonal with 2speed, so use it to make speed is 1
        }
        animator.SetBool("Move", ismove);
        animator.SetFloat("DirX", direction.x);
        animator.SetFloat("DirZ", direction.z);

        // Set animation


        // if it fall under field, reset position
        if (this.transform.position.y < field.transform.position.y - this.transform.localScale.y) {
            this.transform.position = first_position;
            myRigid.velocity = Vector3.zero;
        }
    }
}

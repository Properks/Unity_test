using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private BoxCollider myCollider;
    private Rigidbody myRigid;
    private Vector3 rotation;
    // User this for initilization
    void Start() {
        rotation = this.transform.eulerAngles;
        myCollider = GetComponent<BoxCollider>();
        myRigid = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other) {
        myRigid.AddForce(Vector3.up * 30);
        other.transform.Translate(Vector3.down * 0.1f);
    }
    
    // private void OnCollisionStay(Collision other) {

    // }

    // private void OnCollisionExit(Collider other) { // When other collider exit in collider

    // }
}

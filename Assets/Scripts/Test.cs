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
    
    private void OnTriggerStay(Collider other) { // When other collider is in collider
        other.transform.position += new Vector3(0, 0, 0.1f);
    }

    private void OnTriggerExit(Collider other) { // When other collider exit in collider
        myRigid.useGravity = true;
    }

    private void OnTriggerEnter(Collider other) { // When other collider enter in collider
        myRigid.useGravity = false;
        myRigid.velocity = Vector3.zero;
    }
}

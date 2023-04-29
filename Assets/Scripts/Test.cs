using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // [SerializeField]
    private Rigidbody myRigid;
    private Vector3 rotation;

    // User this for initilization
    void Start() {
        myRigid = GetComponent<Rigidbody>();
        rotation = this.transform.eulerAngles;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            // this.transform.Translate(Vector3.forward * Time.deltaTime);
            // myRigid.velocity = Vector3.forward;

            // myRigid.MovePosition(this.transform.position + Vector3.forward * 5);
            // Regardless mass and inertia

            myRigid.AddForce(Vector3.forward * 10); // Affected by mass and Drag
        }
        else if (Input.GetKey(KeyCode.E))
        {
            // myRigid.angularVelocity = Vector3.up;
            
            // rotation += Vector3.up * 90 * Time.deltaTime;
            // myRigid.MoveRotation(Quaternion.Euler(rotation));
            // Regardless mass and inertia

            myRigid.AddTorque(Vector3.up * 90); // Affected by mass and Drag
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigid.AddExplosionForce(10, this.transform.right, 10);
        }
    }
}

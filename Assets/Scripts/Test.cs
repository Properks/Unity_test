using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // [SerializeField]
    private Rigidbody myRigid;
    // User this for initilization
    void Start() {
        myRigid = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // this.transform.Translate(Vector3.forward * Time.deltaTime);
            myRigid.velocity = Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            myRigid.angularVelocity = Vector3.up;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            myRigid.angularVelocity = Vector3.down;
        }
    }
}

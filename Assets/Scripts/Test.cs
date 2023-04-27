using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 rotation;

    // User this for initilization
    void Start() {
        rotation = this.transform.eulerAngles;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += this.transform.forward * Time.deltaTime;
            // this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime); // Same as above it.
            // forward = Vector3(0, 0, 1)   up = Vector3(0, 1, 0)  right = Vector3(1, 0, 0)

            // rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            // this.transform.eulerAngles = rotation;
            // this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime); // Same as above it. recommand it!!
            // this.transform.eulerAngles += new Vector3(90, 0 ,0) * Time.deltaTime; //FIXME: It has ERROR, when rotation is over 90.

            //Other way to rotate
            rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation);
            // Why use it? -> When any rotation is 90, other rotation has error in euler. (GIMBAL LOCK)


            this.transform.localScale += new Vector3(2, 2, 2) * Time.deltaTime;
            Debug.Log(transform.localScale);
        }
        // Time : Class include something relate time
        // deltatime is Δt. `new Vector3(0, 0, 1) * Time.deltaTime` mean that move 1 per 1 sec to Z axis.
    }
}

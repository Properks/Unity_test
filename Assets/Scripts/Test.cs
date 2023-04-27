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
            this.transform.position += new Vector3(0, 0, 1) * Time.deltaTime;
            // this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime); // Same as above it.

            rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            this.transform.eulerAngles = rotation;
            // this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime); // Same as above it.
            // this.transform.eulerAngles += new Vector3(90, 0 ,0) * Time.deltaTime; //FIXME: It has ERROR, when rotation is over 90.
            Debug.Log(rotation + ", "+ transform.position);
        }
        // Time : Class include something relate time
        // deltatime is Δt. `new Vector3(0, 0, 1) * Time.deltaTime` mean that move 1 per 1 sec to Z axis.
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private BoxCollider myCollider;
    private Vector3 rotation;
    // User this for initilization
    void Start() {
        rotation = this.transform.eulerAngles;
        myCollider = GetComponent<BoxCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 is left button.
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Main camera shot ray to mouse position.
            RaycastHit hitInfo;
            if (myCollider.Raycast(ray, out hitInfo, 1000)) // If ray shot to collider in 1000 distance, Data store in hitInfo and return boolean value. 
            {
                this.transform.position = hitInfo.point;
                Debug.Log(hitInfo.distance);
            }
        }
    }
}

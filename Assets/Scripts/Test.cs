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
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Collider bounds : " + myCollider.bounds); // Center of bounds : Position + Scale * center
            Debug.Log("Collider extents of bounds : " + myCollider.bounds.extents); // Half of Scale * size
            Debug.Log("Collider x of extents of bounds : " + myCollider.bounds.extents.x); // x of extents
            Debug.Log("Collider size : " + myCollider.size); // size of box collider
            Debug.Log("Collider center : " + myCollider.center); // center of collider
            // All of them except extents and extents x can be changed
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rotation += Vector3.up * 90 * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation);
        }
    }
}

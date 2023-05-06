using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private float speed;
    private Vector3 distance; // distance between camera and target;
    // User this for initilization
    void Start() {
        distance = transform.position - target.transform.position;
        // distance = new Vector3(Mathf.Abs(distance.x), Mathf.Abs(distance.y), Mathf.Abs(distance.z));
    }

    void Update() {
        this.transform.LookAt(target.transform.position);
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + distance, speed);
    }
}

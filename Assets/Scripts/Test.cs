using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 rotation;
    [SerializeField]
    private GameObject camera;

    // User this for initilization
    void Start() {
        rotation = this.transform.eulerAngles;
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(camera.transform.position, Vector3.up, 90 * Time.deltaTime);
    } // RotateAround(Around what, X or Y or Z Orthogonality, Speed)
}

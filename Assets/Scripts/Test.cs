using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] // Set in unity
    private Material red_Mat;
    [SerializeField]
    private Material green_Mat;
    private MeshRenderer mesh;
    // User this for initilization
    void Start() {
        mesh = GetComponent<MeshRenderer>();
    }

    void Update() {
        if (Input.GetMouseButton(0)) { // In architecture, Change materials(color) depending on whether it can built in or not.
            mesh.material = green_Mat;
        }
        else if (Input.GetMouseButtonUp(0)) {
            mesh.material = red_Mat;
        }
    }
}

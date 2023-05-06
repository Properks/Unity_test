using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts_for_X : MonoBehaviour
{
    [SerializeField]
    private Material stop_Mat;
    [SerializeField]
    private Material move_Mat;
    [SerializeField]
    private GameObject field;
    private MeshRenderer mesh;
    private Rigidbody myRigid;
    private Vector3 first_position;
    // Start is called before the first frame update
    void Start() {
        myRigid = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
        first_position = this.transform.position;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            myRigid.AddForce(Vector3.right);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)){
            myRigid.AddForce(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.UpArrow)){
            myRigid.AddForce(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.DownArrow)){
            myRigid.AddForce(Vector3.back);
        }

        if (myRigid.velocity != Vector3.zero) {
            mesh.material = move_Mat;
        }
        else {
            mesh.material = stop_Mat;
        }

        if (this.transform.position.y < field.transform.position.y - this.transform.localScale.y) {
            this.transform.position = first_position;
            myRigid.velocity = Vector3.zero;
        }
    }
}

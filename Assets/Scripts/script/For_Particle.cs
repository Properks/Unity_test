using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Particle : MonoBehaviour
{

    private ParticleSystem ps;
    [SerializeField] GameObject GO;
    private BoxCollider collider_of_GO;
    private Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GO.GetComponent<Animator>();
        collider_of_GO = GO.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = GO.transform.position + new Vector3(0, collider_of_GO.bounds.extents.y + 0.1f, 0);
        // if ("Jump_Flash" is playing) { //TODO:
        //     ps.Stop();
        // }
        // else {
        //     ps.Play();
        // }
    }
}

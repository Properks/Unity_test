using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Animation : MonoBehaviour
{
    private Animation myAnimation;
    // Start is called before the first frame update
    void Start()
    {
        myAnimation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            myAnimation.CrossFade("For_Animation");
            // myAnimation.Play("For_Animation");
            // myAnimation.PlayQueued("For_Animation");
            // myAnimation.Blend("For_Animation");
            myAnimation.wrapMode = WrapMode.Once;
        }
        else if (!myAnimation.IsPlaying("For_Animation"))
        {
            myAnimation.Play("For_Animation_2");
        }
    }
}

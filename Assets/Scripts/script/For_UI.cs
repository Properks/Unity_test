using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_UI : MonoBehaviour
{
    [SerializeField] private Text txt_name;
    [SerializeField] private Image img_name;

    public void Change() {
        txt_name.text = "Changed";
        img_name.fillAmount = 0.5f;
    }
}

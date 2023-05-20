using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_UI : MonoBehaviour
{
    [SerializeField] private Text txt_name;
    [SerializeField] private Image img_name;
    [SerializeField] private Sprite sprite;

    private bool isCoolTime = false;
    private float currentTime = 5f;
    private float delaytime = 5f;
    private Color color;
    void Start() {
       color = img_name.color; // Inoreder to transparent 
       color.a = 0f;
    }

    void Update() {
        // img_name.sprite = sprite;
        img_name.color = color;

        if (isCoolTime) {
            currentTime -= Time.deltaTime;
            img_name.fillAmount = currentTime / delaytime; // Display cooldown

   
            if (currentTime <= 0) {
                isCoolTime = false;
                currentTime = delaytime;
                color.a = 0f;
                img_name.fillAmount = currentTime;
            }
        }
    }

    public void Change() {
        txt_name.text = "Changed";
        isCoolTime = true;
        color.a = 1f;
    } 
}

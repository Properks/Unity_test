using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderscripts : MonoBehaviour
{
    [SerializeField] private Slider slider;
    private float dot;
    private bool isClick;

    void Start() {
        dot = 1f;
        isClick = false;
    }

    void Update() {
        if (isClick) {
            dot -= Time.deltaTime;
            slider.value -= Time.deltaTime;
            if (dot <= 0) {
                isClick = false;
                dot = 1f;
            }
        }
    }
    public void button() {
        isClick = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderscripts : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void button() {
        slider.value -= 0.1f;
    }
}

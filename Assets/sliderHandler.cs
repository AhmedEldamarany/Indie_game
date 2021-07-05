using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class sliderHandler : MonoBehaviour
{
    private Slider mySlider;
   [SerializeField] TMP_Text sliderValue;
    [SerializeField] IntSo playerSpeed;
        void Start()
    {
        mySlider = GetComponent<Slider>();
        mySlider.value = playerSpeed.value;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        sliderValue.text = $" {mySlider.value}";
        playerSpeed.value = (int)mySlider.value;
    }
}

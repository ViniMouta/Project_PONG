using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderMaxPoints : MonoBehaviour
{
    public TMP_Text maxPoints;
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
        maxPoints.text = slider.value.ToString();
    }
}

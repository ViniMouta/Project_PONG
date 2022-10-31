using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedColor : MonoBehaviour
{
    public Image uiImage;

    public void ChangeColor(Color c)
    {
        uiImage.color = c;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    public Color color;
    
    [Header("References")]
    public Image uiImage;
    public SelectedColor uiSelectedColor;
    public Player myPlayer;

    void Start()
    {
        uiImage.color = color;
    }

    public void OnClick()
    {
        myPlayer.ChangeColor(color);
        uiSelectedColor.ChangeColor(color);
    }
   

}

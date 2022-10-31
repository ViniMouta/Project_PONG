using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeName : MonoBehaviour
{
    [Header("References")]
    public TextMeshProUGUI uiTextName;
    public TMP_InputField uiInputField;
    public Player player;

    [Header("Color alert")]
    public float speed = 1f;
    public Color startColor => new Color(0.1960f, 0.1960f, 0.1960f, 0.5019608f);
    public Color testColor => Color.gray;
    public Color endColor => Color.red;
    public TextMeshProUGUI placeHolder;
    private bool nameBlank = false;

    private string playerName;

    private void Update()
    {
        BlankNameAlert();
    }
    public void Change_Name()
    {
        if (uiInputField.text == "")
        {
            nameBlank = true;
            return;
        }
        else
        {
            nameBlank = false;
            playerName = uiInputField.text;
            uiTextName.text = playerName;
            player.ChangePlayerName(playerName);

        }
    }

    public Color Lerp(Color firstColor, Color secondColor, float speed) => Color.Lerp(firstColor, secondColor, Mathf.Sin(Time.time * speed));

    public void BlankNameAlert()
    {
        if (nameBlank)
        { 
            placeHolder.color = Lerp(startColor, endColor, 10);
            placeHolder.color = Lerp(endColor, startColor, 10);
        }
        else
        {
            placeHolder.color = startColor;
        }
    }
}

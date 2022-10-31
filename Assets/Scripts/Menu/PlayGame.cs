using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayGame : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("References")]
    public Player player1;
    public Player player2;
    public TextMeshProUGUI uiTextNameP1;
    public TextMeshProUGUI uiTextNameP2;
    public GameObject mainMenu;

    private string player1Name;
    private string player2Name;

    public void Get_Name()
    {
        player1Name = uiTextNameP1.text;
        player1.ChangePlayerName(player1Name);
        
        player2Name = uiTextNameP2.text;
        player2.ChangePlayerName(player2Name);
    }

    public void CloseMenu()
    {
        mainMenu.SetActive(false);
    }
}

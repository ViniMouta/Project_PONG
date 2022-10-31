using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetPlayerName : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("References")]
    public Player player;
    public TextMeshProUGUI uiPlayerName;

    public void SetName()
    {
        uiPlayerName.text = player.playerName;
    }

}

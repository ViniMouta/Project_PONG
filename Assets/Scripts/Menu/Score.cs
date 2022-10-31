using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Player leftPlayer;
    public Player rightPlayer;

    public TextMeshProUGUI uiLeftPlayerName;
    public TextMeshProUGUI uiRightPlayerName;

    public TextMeshProUGUI uiLeftPlayerScore;
    public TextMeshProUGUI uiRightPlayerScore;

    public void UpdateScore()
    {
        uiLeftPlayerName.text = leftPlayer.playerName;
        uiRightPlayerName.text = rightPlayer.playerName;

        uiLeftPlayerScore.text = leftPlayer.currentPoints.ToString();
        uiRightPlayerScore.text = rightPlayer.currentPoints.ToString();
    }

}

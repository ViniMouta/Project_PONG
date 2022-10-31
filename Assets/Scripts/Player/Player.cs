using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    [Header("References")]
    public float speed = 10;
    public Image uiPlayer;
    public TextMeshProUGUI uiPlayerName;
    public string playerName;

    [Header("Key setup")]
    public KeyCode keyCodeMoveUp = KeyCode.UpArrow;
    public KeyCode keyCodeMoveDown = KeyCode.DownArrow;

    public Rigidbody2D myRigidbody2D;

    [Header("Points")]
    public int maxPoints = 3;
    public int currentPoints;
    public TextMeshProUGUI uiTextPoints;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyCodeMoveUp))
        {
            myRigidbody2D.MovePosition(transform.position + transform.up * speed);
        }
        else if (Input.GetKey(keyCodeMoveDown))
        {
            myRigidbody2D.MovePosition(transform.position + transform.up * -speed);
        }
    }

    private void Awake()
    {
        ResetScore();
        SetName(playerName);
    }

    public void AddPoint()
    {
        currentPoints++;
        UpdateUI();
        CheckMaxPoints();
    }

    public void ResetScore()
    {
        currentPoints = 0;
        UpdateUI();
    }
    private void UpdateUI()
    {
        uiTextPoints.text = currentPoints.ToString();
    }

    public void ChangeColor(Color c)
    {
        uiPlayer.color = c;
    }

    public void ChangePlayerName(string n)
    {
        playerName = n;
        SetName(playerName);
    }
    public void SetName(string p)
    {
        uiPlayerName.text = p;
    }

    private void CheckMaxPoints()
    {
        if (currentPoints >= maxPoints)
        {
            GameManager.Instance.EndGame();
            HighscoreManager.Instance.SavePlayerWin(this);
        }
    }

}

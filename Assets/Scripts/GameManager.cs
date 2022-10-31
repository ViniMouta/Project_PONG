using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool first = true;
    [Header("Game Options")]
    public float freezeTime = 2f;
    public Slider sliderMaxPoints;
    public Slider sliderSpeed;
    public int maxPoints = 5;

    [Header("References")]
    public StateMachine stateMachine;
    public List<TriggerPoint> triggerPoints;
    public List<Player> players;
    public Score score;
    public BallBase ballBase;


    [Header("Menus")]
    public GameObject uiMainMenu;
    public GameObject uiScore;

    private void Awake()
    {
        Instance = this;

    }

    public void ResetBall()
    {
        ballBase.CanMove(false);
        ballBase.ResetBall();

        Invoke(nameof(SetBallFree), freezeTime);
    }

    public void SetBallFree()
    {
        ballBase.CanMove(true);
    }
    public void PrepareGame()
    {
        ResetPlayer();
        ballBase.CanMove(true);
        ballBase.ResetBall();
    }
    public void StartGame()
    {
        stateMachine.SwitchState(StateMachine.States.PLAYING);
    }
    public void EndGame()
    {
        stateMachine.SwitchState(StateMachine.States.END_GAME);
    }

    public void ShowMainMenu()
    {
        ballBase.CanMove(false);
        uiMainMenu.SetActive(true);
        score.UpdateScore();
        uiScore.SetActive(true);
    }

    public void ResetPlayer()
    {
        foreach (var player in players)
        {
            player.ResetScore();
            player.maxPoints = maxPoints;
        }
    }

    public void ResetTriggers(bool b)
    {
        foreach (var trigger in triggerPoints)
        {
            trigger.endGame = b;
        }
    }

    public void UpdateMaxPoints()
    {
 
             
        maxPoints = ((int)sliderMaxPoints.value);
    }
}

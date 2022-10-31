using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour
{
    public string tagToCheck = "Ball";
    public Player player;
    public bool endGame = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == tagToCheck)
        {
            CountPoint();
        }
    }

    private void CountPoint()
    {

        player.AddPoint();
        if (!endGame)
        {
            GameManager.Instance.ResetBall();
        }
    }

    public void EndGame()
    {
        endGame = true;
    }
}


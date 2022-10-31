using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallBase : MonoBehaviour
{
    public Vector3 speed = new Vector3(0.5f, 0.5f);
    public Slider slider;
    public string keyToCheck = "Player";

    private Vector3 startPosition;
    public bool _canMove = false;

    private void Awake()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (!_canMove) return;
        transform.Translate(speed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == keyToCheck)
        {
            speed.x *= -1.05f;
        }
        else
        {
            speed.y *= -1;
        }
    }

    public void ResetBall()
    {
        transform.position = startPosition;
    }

    public void CanMove(bool state)
    {
        _canMove = state;
    }

    public void InicialSpeed()
    {
        speed.x = ((float)slider.value);
    }
}

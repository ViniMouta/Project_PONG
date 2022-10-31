using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum States
    {
        MENU,
        PLAYING,
        RESET_POSITION,
        END_GAME
    }

    public Dictionary<States, StateBase> dictionaryState;

    private StateBase _currentState;
    public Player player;
    public float freezeTime = 2f;

    private void Awake()
    {
        dictionaryState = new Dictionary<States, StateBase>();
        dictionaryState.Add(States.MENU, new StateBase());
        dictionaryState.Add(States.PLAYING, new StatePlaying());
        dictionaryState.Add(States.RESET_POSITION, new StateBase());
        dictionaryState.Add(States.END_GAME, new StateEndGame());

        SwitchState(States.MENU);
    }

    private void StartGame()
    {
        SwitchState(States.MENU);
    }

    public void SwitchState(States state)
    {
        if (_currentState != null) _currentState.OnStateExit();

        _currentState = dictionaryState[state];

        if (_currentState != null)
        {
            _currentState.OnStateEnter();
            Debug.Log(_currentState.ToString());
        }
    }

    public void Update()
    {
        if (_currentState != null) _currentState.OnStateStay();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Live,
    Die
}
public class Player : MonoBehaviour
{
    public PlayerState playerState;
    public float CurrentSpeed;
    public float PlusSpeed;
    public float MinSpeed , MaxSpeed;
    public float BreakSpeed;
    bool Gas, Break;
    public float TurnSpeed;
    private GameManager gameManager;
   
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (playerState)
        {
            case PlayerState.Live:
            {
                Gas = Input.GetAxis("Vertical") > 0;
                Break = Input.GetAxis("Vertical") < 0;
                float h = Input.GetAxis("Horizontal");
        
                transform.Translate(h * TurnSpeed * Time.deltaTime, (2 + CurrentSpeed )* Time.deltaTime, 0);
                if (Gas)
                {
                    if (CurrentSpeed < MaxSpeed)
                    {
                        CurrentSpeed += PlusSpeed * Time.deltaTime;
                    }

                    if (CurrentSpeed >= MaxSpeed)
                    {
                        CurrentSpeed = MaxSpeed;
                    }
                }
                else if (CurrentSpeed > 0)
                {
                    CurrentSpeed -= MinSpeed * Time.deltaTime;
                }
                if (CurrentSpeed <= 0)
                {
                    CurrentSpeed = 0;
                }

                if (Break)
                {
                    CurrentSpeed -= BreakSpeed * Time.deltaTime;
                    if (CurrentSpeed <= 0)
                    {
                        CurrentSpeed = 0;
                    }
                }
            } break;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("TrafficCar") && playerState == PlayerState.Live)
        {
            playerState = PlayerState.Die;
            Death();
        }
    }

    public void Death()
    {
        print("Die");
        gameManager.CallRefreshState(GameState.GameOver);
        // Animation Play
        // Sound Play
    }
}


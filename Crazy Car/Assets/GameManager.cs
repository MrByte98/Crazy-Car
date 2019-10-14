using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    InGame,
    GameOver
}
public class GameManager : MonoBehaviour
{
    public GameState gameState;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
     void RefreshState()
    {
        switch (gameState)
        {
            case GameState.InGame:
            {
                
            } break;

            case GameState.GameOver:
            {
                
            } break;
        } 
    }

    public void CallRefreshState(GameState Get)
    {
        gameState = Get;
        RefreshState();
    }

    public void ExitGame()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}

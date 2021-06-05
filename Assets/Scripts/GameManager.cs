using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum GameState {
    InGame,
    StartMenu,
    PauseMenu,
    LevelEndMenu,
    GameOverMenu,
}

public class GameManager : MonoBehaviour
{
    public int currentLevel = 0;
    private int score = 0;
    public GameState gameState = GameState.StartMenu;
    private bool gameActive = false;

    private GameObject menu;
    private GameObject startMenu;
    private GameObject pauseMenu;
    private GameObject endMenu;
    private GameObject hud;

    void Start() {
        menu = GameObject.Find("Menu");
        startMenu = GameObject.Find("StartMenu");
        pauseMenu = GameObject.Find("PauseMenu");
        endMenu = GameObject.Find("EndMenu");
        hud = GameObject.Find("HUD");
        RestartGame();
    }

    public void RestartGame() {
        gameState = GameState.GameOverMenu;
        startMenu.SetActive(true);
        pauseMenu.SetActive(false);
        endMenu.SetActive(false);
        hud.SetActive(false);
        gameActive = false;
    }

    public void StartGame() {
        startMenu.SetActive(false);
        hud.SetActive(true);
        gameActive = true;
    }

    public void SetLevel(int level) {
        currentLevel = level;
        gameActive = true;
    }

    public void PauseGame() {
        gameState = GameState.PauseMenu;
        pauseMenu.SetActive(true);
        hud.SetActive(false);
        gameActive = false;
    }

    public void UnpauseGame() {
        gameState = GameState.InGame;
        pauseMenu.SetActive(false);
        hud.SetActive(true);
        gameActive = true;
    }

    public void EndLevel() {
        gameState = GameState.LevelEndMenu;
        gameActive = false;
    }

    public void GameOver() {
        gameState = GameState.GameOverMenu;
        startMenu.SetActive(false);
        pauseMenu.SetActive(false);
        endMenu.SetActive(true);
        hud.SetActive(false);
        gameActive = false;
    }

    void Update() {

    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField]
    private GameObject mainMenu;
    private bool playerActive = false;
    private bool gameOver = false;
    private bool gameStarted = false;

    public bool GameStarted
    {
        get
        {
            return gameStarted;
        }
    }

    public bool PlayerActive
    {
        get
        {
            return playerActive;
        }
    }

    public bool GameOver
    {
        get
        {
            return gameOver;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        Assert.IsNotNull(mainMenu);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayerCollided()
    {
        gameOver = true;
    }

    public void PlayerStartedGame()
    {
        playerActive = true;
    }

    public void EnterGame()
    {
        mainMenu.SetActive(false);
        gameStarted = true;
    }
}

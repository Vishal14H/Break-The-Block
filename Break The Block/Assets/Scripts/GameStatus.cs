﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f , 10f)] [SerializeField] float gameSpeed=1f;
    [SerializeField] int pointPerBlock = 10;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int currentScore =0;
    [SerializeField] bool isAutoPlayEnabled;



    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


   public void Start()
   {
       scoreText.text = currentScore.ToString();

   }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointPerBlock;
        scoreText.text = currentScore.ToString();
    }
    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}

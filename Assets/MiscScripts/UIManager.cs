﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Sprite[] portraits;
    public GameObject portraitUI;
    public Sprite[] highlights;
    public GameObject switchUI;
    public Sprite[] hearts;
    public GameObject heartUI;
    public Text scoreUI;
    public ScoreController currentScore;

    void Start()
    {
        InvokeRepeating("UpdateScoreUI", 0f, .5f);
    }

    void UpdateScoreUI() {
        scoreUI.text = "Score: "+ currentScore.getCurrentScore();
    }

    public void UpdateSwitchBoard(int buttonNum)
    {
        portraitUI.GetComponent<Image>().sprite = portraits[buttonNum];
        switchUI.GetComponent<Image>().sprite = highlights[buttonNum];
    }

    public void UpdateHealth(int health)
    {
        heartUI.GetComponent<Image>().sprite = hearts[health];
    }
}

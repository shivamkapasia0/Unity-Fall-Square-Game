﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public  Text text;

    public int score;

     void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

     public void ChangeScore(int friendSquarePoint)
     {
         score += friendSquarePoint;
         text.text = "X" + score.ToString();
     }
}

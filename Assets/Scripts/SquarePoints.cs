using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquarePoints : MonoBehaviour
{
    public int FriendSquarePoint = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(FriendSquarePoint);
        }
    }
}

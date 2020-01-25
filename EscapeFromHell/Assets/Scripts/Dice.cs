﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public GameObject[] players;
    public Text text;
    int playerIndex;
    // Start is called before the first frame update
    void Start()
    {
        playerIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(playerIndex == players.Length)
            {
                playerIndex = 0;
            }
            RollDice();
            playerIndex++;
        }
    }

    void RollDice()
    {
        int roll = Random.Range(1, 7);
        players[playerIndex].GetComponent<Player>().Move(roll);
        text.text = roll.ToString();
    }
}
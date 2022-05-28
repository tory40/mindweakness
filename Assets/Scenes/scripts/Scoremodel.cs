using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoremodel
{
    public int score;
    public string playername;
    public Color color;
    public Scoremodel(int playerID) 
    {
        score = 0;
        playername = "Player" + (playerID + 1).ToString();
        switch (playerID) 
        {
            case 0:
                color = Color.red;
                break;
            case 1:
                color = Color.blue;
                break;
            case 2:
                color = Color.yellow;
                break;
            case 3:
                color = Color.green;
                break;
        }
    }
}

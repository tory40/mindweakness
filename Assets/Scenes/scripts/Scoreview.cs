using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreview : MonoBehaviour
{
    [SerializeField] Text playernum;
    [SerializeField] Text playerscore;

    public void Show(Scoremodel scoremodel) 
    {
        playernum.text = scoremodel.playername;
        playernum.color = scoremodel.color;
        playerscore.text = scoremodel.score.ToString();
        playerscore.color = scoremodel.color;
    }
    public void Point(Scoremodel scoremodel) 
    {
        playerscore.text = scoremodel.score.ToString();
    }
}

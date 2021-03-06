using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscore : MonoBehaviour
{
    Scoreview view;// 見た目の操作
    Scoremodel model;// データの操作

    private void Awake()
    {
        view = GetComponent<Scoreview>();
    }

    public void Init(int playerID)
    {
        model = new Scoremodel(playerID);
        view.Show(model);
    }
    public void Point() 
    {
        model.score += 2;
        view.Point(model);
    }
}

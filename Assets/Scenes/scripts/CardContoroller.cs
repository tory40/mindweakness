using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardContoroller : MonoBehaviour
{
    CardView view;// 見た目の操作
    CardModel model;// データの操作

    private void Awake()
    {
        view = GetComponent<CardView>();
    }

    public void Init(int cardID, int transnum)
    {

        model = new CardModel(cardID, transnum);
        view.Show(model);

    }
    public void Hide()
    {
        view.Hide();
    }

    public void Choice()
    {
        if (!model.clean)
        {
            GameManager.Choice(model.transnum, model.marknum, model.number);
        } 
    }
    public void Clean()
    {
        model.PanelColor();
        if (Button.button)
        {
            view.Grass(model);
        }
        else 
        {
            view.Fade(model);
        }
    }
}

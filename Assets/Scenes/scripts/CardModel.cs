using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel
{
    public int number;
    public Sprite icon;
    public int marknum;
    public int transnum;
    public bool clean = false;
    public Color color;
    public CardModel(int cardID ,int transnumber)
    {
        int cardID2 = GameManager.mark[(cardID/Deck.count)];
        CardEntity cardEntity = Resources.Load<CardEntity>("CardEntitylist/Card" + cardID2);
        number = cardID%Deck.count;
        icon = cardEntity.icon;
        transnum =transnumber;
        marknum = cardID2;
        switch (Deck.pear) 
        {
            case 0:
                marknum = 0;
                break;
            case 1:
                marknum = cardID2%2;
                break;
            case 2:
                marknum = (cardID2+1)/2;
                break;
            case 3:
                marknum = cardID2;
                break;
        }
    }

    public void PanelColor() 
    {
        switch (GameManager.playernum)
        {
            case 1:
                color = Color.red;
                break;
            case 2:
                color = Color.blue;
                break;
            case 3:
                color = Color.yellow;
                break;
            case 4:
                color = Color.green;
                break;
            case 10:
                color = Color.gray;
                break;
            default:
                color = Color.black;
                break;
        }
    }
}


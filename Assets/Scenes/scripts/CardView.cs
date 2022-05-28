using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    [SerializeField] Text numberText;
    [SerializeField] Image iconImage;
    [SerializeField] RectTransform iconsize;
    [SerializeField] RectTransform textsize;
    [SerializeField] Image panel;
    [SerializeField] Image setpanel;
    Color one = new Color(0f, 0f, 0f, 1f);
    List<string> texts = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "1", "B", "C", "D", "E", "F", "G", "H", "I", "L", "M", "N", "O,", "P", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
    public void Show(CardModel cardModel)
    {
        numberText.text = texts[cardModel.number];
        iconImage.sprite = cardModel.icon;
        float sizeper = GameManager.sizex / 100;
        iconsize.sizeDelta = new Vector2(60 * sizeper, 60 * sizeper);
        Vector3 iconposition = new Vector3(0, 25 * sizeper, 0);
        iconsize.position += iconposition;
        textsize.sizeDelta = new Vector2(100 * sizeper, 50 * sizeper);
        Vector3 textposition = new Vector3(0, -40 * sizeper, 0);
        textsize.position += textposition;

        numberText.fontSize = (int)(40 * sizeper);
    }
    public void Hide()
    {
        numberText.text = "";
    }
    public void Fade(CardModel cardModel) 
    {
        numberText.text = texts[cardModel.number];
        iconImage.sprite = cardModel.icon;
        panel.color = cardModel.color;
    }
    public void Grass(CardModel cardModel) 
    {
        numberText.text = "";
        iconImage.sprite = null;
        panel.color -= one;
        iconImage.color -= one;
    }
}


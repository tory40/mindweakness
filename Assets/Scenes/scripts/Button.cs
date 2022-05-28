using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    [SerializeField] Text Text;
    static public bool button = true;
   public void Tap() 
    {
        if (button) 
        {
            button = false;
            Text.text = "grass";
            foreach (var cards in GameManager.decks) 
            {
             
            }
        }
        else
        {
            button = true;
            Text.text = "color";
        }
    }
}

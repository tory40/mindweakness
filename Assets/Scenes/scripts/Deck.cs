using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Deck : MonoBehaviour
{
    static public int pear;
    static public int deck;
    static public int mark;
    static public int count;
    static public int player;
    static public bool ta;
    [SerializeField] Text peartext;
    [SerializeField] Text decktext;
    [SerializeField] Text marktext;
    [SerializeField] Text counttext;
    [SerializeField] Text playertext;
    void Start()
    {
        pear = 0;
        count = 13;
        player = 1;
        PearSet();
    }

    public void PearUP() 
    {
        if (pear < 3)
        {
            ++pear;
            PearSet();
        }
    }

    public void PearDown()
    {
        if (pear > 0)
        {
            --pear;
            PearSet();
        }
    }
    
    public void PearSet() 
    {
        switch (pear) 
        {
            case 0:
                deck = 1;
                mark = 4;
                peartext.text = "countonly";
                break;
            case 1:
                deck = 1;
                mark = 4;
                peartext.text = "+color";
                break;
            case 2:
                deck = 1;
                mark = 4;
                peartext.text = "+mark";
                break;
            case 3:
                deck = 2;
                mark = 4;
                peartext.text = "all";
                break;
            default :
                break;
        }
        Rename();
    }
    public void Rename() 
    {
        decktext.text = deck.ToString();
        marktext.text = mark.ToString();
        counttext.text = count.ToString();
        playertext.text = player.ToString();
    }
    public void DeckUP()
    {
        if (deck<4) 
        {
            if (pear == 3)
            {
                deck += 2;
            }
            else
            {
                ++deck;
            }
            Rename();
        }
    }
    public void DeckDown()
    {
        if (deck>1) 
        {
            if (pear == 3)
            {
                if (deck>2)
                {
                    deck -= 2;
                }
            }
            else
            {
                --deck;
            }
            Rename(); 
        }
    }
        public void MarkUP()
    {
        if (mark<10)
        {
            if (pear == 3)
            {
                ++mark;
            }
            else
            {
                if (pear != 1||mark<8) 
                {
                    mark += 2;
                }
            }
            Rename();
        }
    }
    public void MarkDown()
    {
        if (mark>1)
        {
            if (pear == 3)
            {
                --mark;
            }
            else
            {
                if (mark>2)
                {
                    mark -= 2;
                } 
            }
            Rename(); 
        }
    }
    public void CountUP()
    {
        if (count<36)
        {
            ++count;
            Rename();
        }
    }
    public void CountDown()
    {
        if (count > 1)
        {
            --count;
            Rename();
        }
    }
    public void PlayerUP()
    {
        if (player < 4)
        {
            ++player;
            Rename();
        }
    }
    public void PlayerDown()
    {
        if (player > 1)
        {
            --player;
            Rename();
        }

    }
    public void Timeattack() 
    {
        ta = true;
        SceneManager.LoadScene("SampleScene");
    }

    public void VS() 
    {
        ta = false;
        SceneManager.LoadScene("SampleScene");
    }
}

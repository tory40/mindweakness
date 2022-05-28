using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    List<int> deck = new List<int>();
    static public List<int> decks = new List<int>();
    [SerializeField] CardContoroller cardPrefab;
    static public List<CardContoroller> cards = new List<CardContoroller>();
    [SerializeField] Transform settransform;
    static public List<int> mark;
    [SerializeField] GridLayoutGroup grid;
    static public int playernum;
    [SerializeField] GameObject timer;
    [SerializeField] Playerscore playerpoint;
    [SerializeField] Transform scorebord;
    static public List<Playerscore> players = new List<Playerscore>();
    void Start()
    {
        if (Deck.ta) 
        {
            timer.SetActive(true);
            playernum = 10;
        }
        else
        {
            playernum = 1;
            Playersscore();
        }
        for (int j = 0; j < Deck.deck; ++j)
        {
            for (int i = 0; i < Deck.mark * Deck.count; ++i)
            {
                deck.Add(i);
            }
        }
        Mark();
        Count();
        openCreateCard(settransform);
    }
    public void Playersscore()
    {
        for(int i =0;i<Deck.player;++i)
        {
            Playerscore playerscore = Instantiate(playerpoint,scorebord,false);
            playerscore.Init(i);
            players.Add(playerscore);
        }
    }
    void Update()
    {

    }
    public void openCreateCard(Transform set)
    {
            for (int i = 0; i < deck.Count; ++i)
            {
                CardContoroller card = Instantiate(cardPrefab, set, false);
                card.Init(deck[i],i);
                cards.Add(card);
            }
    }

    public void Mark() 
    {
        switch (Deck.pear) 
        {
            case 0:
                mark = new List<int> { 1, 4, 6, 7, 2, 3, 5, 8, 9, 10 };
                break;
            case 1:
                mark = new List<int> { 1, 7, 4, 6, 2, 8, 3, 5 };
                break;
            case 2:
                mark = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                break;
            case 3:
                mark = new List<int> { 1, 4, 6, 7, 2, 3, 5, 8, 9, 10 };
                break;
        }
            
    }

    static public float sizex;
    float l;
    float m;

    public void Count()
    {
        //全体の寸法を入力
        int wide = 960;
        int height = 480;
        //オブジェクトの数を入力
        int count = Deck.deck*Deck.mark*Deck.count;
        //オブジェクト、スペースの比率を入力
        float objxper = 10;
        float objyper = 15;
        float spaceper = 2;
        float xper = (objxper + spaceper) / wide;
        float yper = (objyper + spaceper) / height;
        int step = 1;
        int line = 1;
        Vector2 size;
        Vector2 space;
        float x;
        float y;
        float i;
        while (true)
        {

            if (count > step * line)
            {
                if (xper * step < yper * line)
                {
                    ++step;
                }
                else
                {
                    ++line;
                }
                continue;
            }
            break;
        }
        if (xper * step < yper * line)
        {
            y = ((height / line) * objyper) / (objyper + spaceper);
            i = y * spaceper / objyper;
            x = y * objxper / objyper;
            size = new Vector2(x, y);
            space = new Vector2(i, i);

        }
        else
        {
            x = ((wide / step) * objxper) / (objxper + spaceper);
            i = x * spaceper / objxper;
            y = x * objyper / objxper;
            size = new Vector2(x, y);
            space = new Vector2(i, i);
        }
        grid.cellSize = size;
        grid.spacing = space;
        float j = (wide - (x * step) - (i * (step - 1)));
        float k = (height - (y * line) - (i * (line - 1)));
        if (step>2) 
        {
            l = j / (step + 2);
        }
        else 
        {
            l = 0;
        }
        if (line>2)
        {
            m = k / (line + 2);
        }
        else
        {
            m = 0;
        }
        Vector2 revision = new Vector2(l,m);
        grid.spacing += revision;
        j = ((wide - (x * step) - ((i+l) * (step - 1))) / 2);
        k = ((height - (y * line) - ((i+m) * (line - 1))) / 2);
        grid.padding.top = (int)k;
        grid.padding.left = (int)j;
        grid.padding.right = (int)j;
        grid.padding.bottom = (int)k;
        sizex = x;

    }
    static bool first = true;
    static int a;
    static int b;
    static int c;
    static public bool first2 = false;
    static public void Choice(int i,int j,int k)
    {
        if (first)
        {
            first2 = true;
            first = false;
            a = i;
            b = j;
            c = k;
        }
        else
        {
            if (a!=i) 
            {
                first = true;
                if (b == j && c == k)
                {
                    cards[a].Clean();
                    cards[i].Clean();
                    decks.Add(a);
                    decks.Add(i);
                    if (playernum != 10) 
                    {
                        players[playernum-1].Point();
                    }
                }
                else
                {
                    if (playernum != 10)
                    {
                        ++playernum;
                        if (playernum > Deck.player)
                        {
                            playernum = 1;
                        }
                    }
                }
            }
        }
    }
}

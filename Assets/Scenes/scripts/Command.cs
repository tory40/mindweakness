using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command : MonoBehaviour
{
    bool coma = false;
    bool comb = false;

    public void Comat() 
    {
        Debug.Log("ona");
        coma = true;
    }
    public void Combt()
    {
        Debug.Log("onb");
        comb = true;
    }
    public void Comaf()
    {
        Debug.Log("offa");
        coma = false;
    }
    public void Combf()
    {
        Debug.Log("offb");
        comb = false;
    }

    public void ComInit() 
    {
        if (coma & comb) 
        {
            Debug.Log("com");
        }
    } 
}

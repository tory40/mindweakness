using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pushstart : MonoBehaviour
{
    bool canstart = true;
    public void PressStart()
    {
        if (canstart)
        {
            canstart = false;
            SceneManager.LoadScene("SampleScene");
        }
    }
}

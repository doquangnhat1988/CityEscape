using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIExit : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}

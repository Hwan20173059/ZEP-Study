using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;

    private void Update()
    {
        TimerText.text = DateTime.Now.ToString("HH:mm:ss");
    }
}

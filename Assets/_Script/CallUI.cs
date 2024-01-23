using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallUI : MonoBehaviour
{
    public GameObject CallingUI;

    public void UIButtonOn()
    {
        OnButton(CallingUI);
    }

    public void OnButton(GameObject UI)
    {
        if (UI.activeSelf == true)
        {
            CallingUI.SetActive(false);
        }
        else
        {
            CallingUI.SetActive(true);
        }
        
    }
}

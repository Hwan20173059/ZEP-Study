using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public string Name;
    public Text nameUI;

    private void Update()
    {
        nameUI.text = Name;
    }
}

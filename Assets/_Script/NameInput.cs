using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public GameObject Title;
    public GameObject JoinButton;
    public GameObject FalseJoinButton;

    public InputField playerNameInput;

    public PlayerName playername;
    private string playerName = null;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }

    private void Update()
    {
        InputButton(playerNameInput.text.Length);
    }

    public void InputName()
    {
        playername.Name = playerNameInput.text;
        Title.SetActive(false);
    }

    public void InputButton(int Length)
    {
        if (Length < 2 || Length > 10)
        {
            JoinButton.SetActive(false);
            FalseJoinButton.SetActive(true);
        }
        else
        {
            JoinButton.SetActive(true);
            FalseJoinButton.SetActive(false);
        }
    }
}

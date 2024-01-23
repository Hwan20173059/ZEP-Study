using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    public GameObject Character1;
    public GameObject Character2;

    public int ChoosenCharacter = 1;

    public Sprite Character1_Sprite;
    public Sprite Character2_Sprite;

    public Image CharacterChoose;

    public GameObject CharacterSelectPage;

    private void Update()
    {
        if(ChoosenCharacter == 1)
            CharacterChoose.sprite = Character1_Sprite;
        else if (ChoosenCharacter == 2)
            CharacterChoose.sprite = Character2_Sprite;
    }

    public void SelectCharacterPage() 
    {
        CharacterSelectPage.SetActive(true);
    }

    public void SelectCharacter1()
    {
        Character1.SetActive(true);
        Character2.SetActive(false);
        CharacterSelectPage.SetActive(false);
        ChoosenCharacter = 1;
    }

    public void SelectCharacter2()
    {
        Character1.SetActive(false);
        Character2.SetActive(true);
        CharacterSelectPage.SetActive(false);
        ChoosenCharacter = 2;
    }
}

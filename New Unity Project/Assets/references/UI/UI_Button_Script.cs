using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button_Script : MonoBehaviour
{
    public Text _buttonText;

    void Start()
    {
        _buttonText = GetComponent<Text>();
    }

    public void setButtonText(string name) {
        _buttonText.text = name;
    }
}

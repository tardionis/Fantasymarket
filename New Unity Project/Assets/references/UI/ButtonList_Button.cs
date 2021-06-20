﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonList_Button : MonoBehaviour
{
    [SerializeField]
    private Text myText;

    public void setText(string textString) {
        myText.text = textString;
    }
}

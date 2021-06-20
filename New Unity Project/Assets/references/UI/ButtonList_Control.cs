using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonList_Control : MonoBehaviour
{
    [SerializeField]
    private GameObject buttonTemplate;

    public void GenerateButton(string[] buttonNames) {
        foreach (string s in buttonNames)
        {
            GameObject button = Instantiate(buttonTemplate) as GameObject;
            button.SetActive(true);

            button.GetComponent<ButtonList_Button>().setText(s);

            button.transform.SetParent(buttonTemplate.transform.parent, false);
        }
    }
}

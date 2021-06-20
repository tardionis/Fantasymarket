using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadFileNames : MonoBehaviour
{
    FileLoader _fileLoader;
    [SerializeField]
    private InputField _inputField;

    void Start()
    {
        _fileLoader = GameObject.Find("EventSystem").GetComponent<FileLoader>();
        string[] SaveNames = _fileLoader.getSaveNames();
        GetComponentInChildren<ButtonList_Control>().GenerateButton(SaveNames);
    }

    public void addSaveFile() {
        string fileName = _inputField.text;
        _fileLoader.addSaveFile(fileName);
    }

    public void QuitGame() {
        Application.Quit();
    }
}

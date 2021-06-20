using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FileLoader : MonoBehaviour
{
    private string[] _saves;
    private string _selectedFile;
    private GameCollections _collections;
    private const string _key = "saveFiles";
    private const string _collectionsKey = "collections/";
    private const string _defaultName = "'No Name'";

    

    void Awake() {
        load();
        GameEvents.SerializObject += Save;
    }

    void Save() {
        SaveData.Save(_collections, _collectionsKey +_key);
    }

    void load() {
        _saves = SaveData.Load<string[]>(_key);
        if (_saves == default(string[]))
        {
            _saves = new string[0];
        }
    }

    public void addSaveFile(string fileName) {
        if (fileName == "")
        {
            fileName = _defaultName;
        }
        string[] newSaves = new string[_saves.Length+1];
        for (int i = 0; i < _saves.Length; i++)
        {
            newSaves[i] = _saves[i];
        }
        newSaves[_saves.Length] = fileName;
        _saves = newSaves;
        Debug.Log("Game schould be saved");
        SaveData.Save<string[]>(_saves, _key);
    }

    ///<summary>
    ///Returns the name of a file. If no SaveFile was created at this point, null is returned.
    ///<summary>
    public string getSavefile(int index) {
        if (index >= _saves.Length || index < 0)
        {
            return null;
        }
        _selectedFile = _saves[index];
        _collections= SaveData.Load<GameCollections>(_collectionsKey +_selectedFile);
        return _selectedFile;
    }

    ///<sammary>
    ///Returns _saves for button Generation
    ///<sammary>
    public string[] getSaveNames()
    {
        return _saves;
    }

    public void deleteSaveFile() {
        ///not implemented
    }

    public void reset() {
        for (int i = 0; i < _saves.Length; i++)
        {
            _saves = new string[0];
        }
        SaveData.Save(_saves, _key);
    }
}

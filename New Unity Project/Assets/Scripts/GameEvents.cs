using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    [SerializeField]
    private GameObject[] canvases;

    /// <summary>
    /// Call to save all objects.
    /// </summary>
    public static System.Action SerializObject;

    /// <summary>
    /// Subscribes its storage method here to be saved when SerializObject is Invoked.
    /// </summary>
    public static void OnSerializObject() {
        SerializObject?.Invoke();
    }

    /// <summary>
    /// Changes the active canvas to the canvas with the passed index. 
    ///If the index passed does not have an assigned canvas, all canvases become inactive.
    /// </summary>
    public void SwitchCanvas(int index) {
        for (int i = 0; i < canvases.Length; i++)
        {
            if (i == index)
            {
                canvases[i].SetActive(true);
            } else
            {
                canvases[i].SetActive(false);
            }
        }
    }
}

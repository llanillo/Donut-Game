using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour, IGameManager
{
    [SerializeField] private GameObject canvas;
    
    private MainCanvas mainCanvas;

    private Canvas currentCanvas;

  
    public ManagerStatus status { get; private set; }
    
    public void Startup()
    {
        mainCanvas = canvas.GetComponentInChildren<MainCanvas>();

        mainCanvas.Startup();
    }

    private void Update()
    {
        mainCanvas.UpdateAmmo();
    }
}

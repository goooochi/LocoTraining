using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TitleUIView : MonoBehaviour
{
    public Action OnClickGameStartListener;

    [SerializeField] private GameObject sceneLoadingPanel;
    [SerializeField] private Slider sceneLoadingProgressBar;

    //要件にはないけれどテスト用
    public void DisplaySceneLoadingProgress(float progress)
    {
        sceneLoadingPanel.SetActive(true);
        sceneLoadingProgressBar.value = progress;
    }

    public void OnClickGameStartButton()
    {
        OnClickGameStartListener?.Invoke();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Cysharp.Threading.Tasks;

public class TitleUIPresenter : MonoBehaviour
{
    [SerializeField] private TitleUIView titleUIView;

    private void Awake()
    {
        SetEvent();
    }

    private void SetEvent()
    {
        titleUIView.OnClickGameStartListener = LoadGameScene;
    }

    private async void LoadGameScene()
    {
        //シーンロードの非同期処理を取得し、読み込みの間は進行度を表示
        var loadScene = new SceneLoader();
        var async = loadScene.LoadAsync(GameScane.BVHModel);

        while(!loadScene.IsDoneSceneLoad())
        {
            var progress = loadScene.GetSceneLoadProgress();
            titleUIView.DisplaySceneLoadingProgress(progress);

            await UniTask.Yield();
        }
    }
}
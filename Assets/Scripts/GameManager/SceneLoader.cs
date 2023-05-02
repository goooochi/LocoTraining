using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using ModestTree;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameScane
{
    Title,
    BVHModel
}

public class SceneLoader
{
    private Dictionary<GameScane, string> sceneNameDictionary = new Dictionary<GameScane, string>()
    {
        { GameScane.Title, "Title" },
        { GameScane.BVHModel, "BVHModel" }
    };

    private AsyncOperation currentAsyncOperation;
    private const float DEF_SCENELOAD_MAX_PROGRESS = 0.9f;

    /// <summary>
    /// 特に非同期処理を行わない時にシーンを読み込む用
    /// </summary>
    /// <param name="scene">読み込みたいシーン</param>
    public void Load(GameScane scene)
    {
        SceneManager.LoadScene(sceneNameDictionary[scene]);
    }

    public float GetSceneLoadProgress()
    {
        return currentAsyncOperation.progress / DEF_SCENELOAD_MAX_PROGRESS;
    }

    public bool IsDoneSceneLoad()
    {
        return GetSceneLoadProgress() >= 1.0f;
    }

    /// <summary>
    /// 非同期にシーンを読み込み呼び出し側で何かの処理をするためのシーン呼び出しメソッド。
    /// </summary>
    /// <param name="scene">呼び出したいシーン</param>
    /// <returns>シーン読み込みを行う非同期AsyncOperation</returns>
    public AsyncOperation LoadAsync(GameScane scene)
    {
        //シーンの非同期読み込み
        currentAsyncOperation = SceneManager.LoadSceneAsync(sceneNameDictionary[scene]);
        return currentAsyncOperation;
    }
}
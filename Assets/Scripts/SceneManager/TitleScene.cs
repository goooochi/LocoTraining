using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class TitleScene : MonoBehaviour
{
    [SerializeField] private Button _loadSceneButton;
    
    private void Start()
    {
        _loadSceneButton.onClick.AddListener(
            async () =>
            {
                await Test();
            });
    }
    


    // Start is called before the first frame update
    public async Task Test()
    {
        // シーンBをロードしてコンポーネントを取得
        var sceneB = await SceneLoader.Load<VideoPlayer>("BVHModel", LoadSceneMode.Single);
        sceneB.Play();
    }
    
    

}

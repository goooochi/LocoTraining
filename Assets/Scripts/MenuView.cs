using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace MenusView
{
    //Viewを扱うクラス
    public class MenuView : MonoBehaviour
    {
        
        
        [SerializeField] private VideoPlayer _videoPlayer;
        [SerializeField] private RawImage _videoRawImage;

        [SerializeField] private Button _training1Button;
        [SerializeField] private Button _training2Button;
        [SerializeField] private Button _training3Button;
        [SerializeField] private Button _training4Button;

        // private Button o = Observable.Merge
        // (_training1Button.OnClickAsObservable()(_ => Debug.Log("AAA")),
        //     _training2Button.OnClickAsObservable()(_ => Debug.Log("AAA"),
        //         _training3Button.OnClickAsObservable()(_ => Debug.Log("AAA"),
        //             _training4Button.OnClickAsObservable()(_ => Debug.Log("AAA")
        // );
        
        
    }
}


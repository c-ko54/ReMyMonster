using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    //マップシーンで専用のBGMを流す
    void Start()
    {
        SoundManager.Instance.PlayBGM(BGMSoundData.BGM.map);
    }
}

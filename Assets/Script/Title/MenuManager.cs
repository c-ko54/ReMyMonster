using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    //タイトルのBGMを流す
    void Start()
    {
        SoundManager.Instance.PlayBGM(BGMSoundData.BGM.Title);
    }


}

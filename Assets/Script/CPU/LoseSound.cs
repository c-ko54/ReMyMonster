using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseSound : MonoBehaviour
{
    //敗北時SEを再生する
    void Start()
    {
        SoundManager.Instance.PlayBGM(BGMSoundData.BGM.none);
        SoundManager.Instance.PlaySE(SESoundData.SE.lose);
    }


}

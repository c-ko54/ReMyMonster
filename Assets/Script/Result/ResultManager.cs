using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManager : MonoBehaviour
{

    void Start()
    {
        //勝利時にSEを鳴らす
        SoundManager.Instance.PlayBGM(BGMSoundData.BGM.none);
        SoundManager.Instance.PlaySE(SESoundData.SE.fanfare);
    }


}

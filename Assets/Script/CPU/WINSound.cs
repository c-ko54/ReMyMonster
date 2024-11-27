using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WINSound : MonoBehaviour
{
    void Start()
    {
        //勝利時のSEを鳴らす
        //ラスボス勝利時は専用SE
        SoundManager.Instance.PlayBGM(BGMSoundData.BGM.none);
        if (GameManager.instance.CPUNUM == 4)
        {
            SoundManager.Instance.PlaySE(SESoundData.SE.Complete);
        }
        else
        {
            SoundManager.Instance.PlaySE(SESoundData.SE.clea);
        }

    }

}

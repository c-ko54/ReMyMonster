using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSound : MonoBehaviour
{
    //ボタンを押したときにセレクト音を鳴らす
    public void OnClick()
    {
        SoundManager.Instance.PlaySE(SESoundData.SE.select);
    }
}

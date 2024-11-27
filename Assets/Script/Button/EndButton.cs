using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : MonoBehaviour
{
    //終了する
    public void OnClick()
    {
        SoundManager.Instance.PlaySE(SESoundData.SE.select);
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
        #else
        Application.Quit();//ゲームプレイ終了
        #endif
    }
}

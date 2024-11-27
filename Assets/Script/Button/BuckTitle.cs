using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BuckTitle : MonoBehaviour
{
    //進行状況をリセットしてタイトルに戻る
    public void OnClick()
    {
        SoundManager.Instance.PlaySE(SESoundData.SE.select);
        StatesManager.instance.PlayerNumber = 1;
        SceneManager.LoadScene("Title");
        if (GameManager.instance.cpuSelect == true)
        {
            GameManager.instance.cpuSelect = false;
            GameManager.instance.CPUNUM = 0;
        }
    }
}

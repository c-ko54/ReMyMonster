using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoCreateCPU : MonoBehaviour
{
    //CPU登場シーンに移行する
    public void OnClick()
    {
        GameManager.instance.cpuSelect = true;
        SoundManager.Instance.PlaySE(SESoundData.SE.select);
        SceneManager.LoadScene("CPU1PCreateScene 1");
    }
}

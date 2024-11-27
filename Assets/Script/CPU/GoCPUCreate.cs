using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoCPUCreate : MonoBehaviour
{
    public void OnClick()
    {
        //CPU出現時の出現SEとシーン移行
        SoundManager.Instance.PlaySE(SESoundData.SE.select);
        SceneManager.LoadScene("SummonCPU");
    }
}

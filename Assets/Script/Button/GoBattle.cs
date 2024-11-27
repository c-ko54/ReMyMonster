using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBattle : MonoBehaviour
{
    //バトルシーンに移行する
    public void onclick()
    {
        SoundManager.Instance.PlaySE(SESoundData.SE.select);
        SceneManager.LoadScene("BatleScene");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoMap : MonoBehaviour
{
    //マップに移行する
    public void MapGO()
    {
        SoundManager.Instance.PlaySE(SESoundData.SE.select);
        SceneManager.LoadScene("MapSccene");
    }
}

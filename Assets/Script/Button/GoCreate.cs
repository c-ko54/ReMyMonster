using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoCreate : MonoBehaviour
{
    public string scenename;
    // Start is called before the first frame update

    //scenenameのシーンに移行する
    public void OnClick()
    {

        SoundManager.Instance.PlaySE(SESoundData.SE.select);
        SceneManager.LoadScene(scenename);
    }
}

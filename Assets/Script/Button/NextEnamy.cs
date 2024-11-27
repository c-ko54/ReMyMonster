using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class NextEnamy : MonoBehaviour
{
    //HintSceneに移行する
    public void OnClick()
    {        
        SceneManager.LoadScene("HintScene");
    }
}

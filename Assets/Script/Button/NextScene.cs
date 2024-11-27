using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    //一人目作成時なら二人目作成画面、二人目作成時なら確認画面に移行する
    public void GoNext()
    {
        SoundManager.Instance.PlaySE(SESoundData.SE.select);
        if(StatesManager.instance.PlayerNumber == 1){
            StatesManager.instance.PlayerNumber = StatesManager.instance.PlayerNumber + 1;
            SceneManager.LoadScene("2PCreateScene");
        }else{
            SceneManager.LoadScene("GoBattleScene");
        }
    }
}

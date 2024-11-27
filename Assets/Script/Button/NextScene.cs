using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoNext()
    {
        if(StatesManager.instance.PlayerNumber == 1){
            StatesManager.instance.PlayerNumber = StatesManager.instance.PlayerNumber + 1;
            SceneManager.LoadScene("2PCreateScene");
        }else{
            SceneManager.LoadScene("GoBattleScene");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BuckTitle : MonoBehaviour
{

    public void OnClick()
    {
        StatesManager.instance.PlayerNumber = 1;
        SceneManager.LoadScene("Title");
    }
}

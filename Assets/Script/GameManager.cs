using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : SingletonBehavior<GameManager>
{
    public bool FirstLoad = false;
    public bool cpuSelect;
    public int CPUNUM;
    public int CPUID;
    public string[] Hint;


    public List<int> GetHint = new List<int>() { };
    public List<int> GetHintEX = new List<int>() { };
    void Start()
    {
        cpuSelect = false;
        CPUNUM = 0;
        CPUID = -1;
        SoundManager.Instance.PlayBGM(BGMSoundData.BGM.Title);


        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {

    }


}






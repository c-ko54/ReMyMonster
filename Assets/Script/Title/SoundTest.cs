using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    
    [SerializeField]private AudioSource source; //スピーカー・CDプレイヤー

    [SerializeField] public AudioClip BGM1; //音源データ1

    [SerializeField] public AudioClip BGM2; //音源データ2
    [SerializeField] public AudioClip Summon; //音源データ2
    [SerializeField] public AudioClip Select; //音源データ2
    [SerializeField] public AudioClip Atack1; //音源データ2
    [SerializeField] public AudioClip Atack2;

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //左クリック
        {
            source.clip = Atack1; //再生したいclipを指定して
            source.Play(); //再生
        }
        if (Input.GetMouseButtonDown(1)) //右クリック
        {
            source.clip = Atack2; //再生したいclipを指定して
            source.Play(); //再生
        }

        
    }
}
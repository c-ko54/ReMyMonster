using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageKeep : SingletonBehavior<ImageKeep>
{
    //モンスター画像の保存、登録
    
    public Sprite[] Images;
    public int RareImage = 1;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}

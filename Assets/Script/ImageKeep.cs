using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageKeep : SingletonBehavior<ImageKeep>
{
    public Sprite[] Images;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}

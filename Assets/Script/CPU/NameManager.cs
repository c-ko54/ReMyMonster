using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NameManager : SingletonBehavior<NameManager>
{
    //CPUの名前を保存する
    public string[] names;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineManager
{
    private static CoroutineManager _instance;
    private readonly List<IEnumerator> _coroutines = new List<IEnumerator>();

    // シングルトンインスタンスを取得
    public static CoroutineManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new CoroutineManager();
            }
            return _instance;
        }
    }

    // コルーチンを開始
    public void StartCoroutine(IEnumerator coroutine)
    {
        _coroutines.Add(coroutine);
    }

    // 全コルーチンを更新
    public void Update()
    {
        for (int i = _coroutines.Count - 1; i >= 0; i--)
        {
            if (!_coroutines[i].MoveNext())
            {
                _coroutines.RemoveAt(i);
            }
        }
    }
}
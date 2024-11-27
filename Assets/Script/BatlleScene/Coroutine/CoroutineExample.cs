using System.Collections;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
    [SerializeField] windowONOFF windowmanage;
    void Start()
    {
        // コルーチンを開始
        CoroutineManager.Instance.StartCoroutine(MyCoroutine());
    }

    void Update()
    {
        // コルーチンマネージャーを更新
        CoroutineManager.Instance.Update();
    }

    IEnumerator MyCoroutine()
    {
        windowmanage.WindowON();

        Debug.Log("MyCoroutine OK");
        //5秒待つ
        yield return new WaitForSeconds(5);


        windowmanage.WindowOFF();
    }
}
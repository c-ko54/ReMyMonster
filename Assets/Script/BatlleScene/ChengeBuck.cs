using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChengeBuck : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Sprite Normal;
    [SerializeField] Sprite CPU;
    [SerializeField] private Image image;

    void Start()
    {
        //モードに合わせた背景の変更
        if (GameManager.instance.cpuSelect == false)
        {
            image.sprite = Normal;
        }
        else
        {
            image.sprite = CPU;
            
        }
    }
}

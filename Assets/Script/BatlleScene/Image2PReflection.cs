using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Image2PReflection : MonoBehaviour
{
    private Image image;
    void Start()//2Pの画像を割り当てる
    {
        image = GetComponent<Image>();
        State state = StatesManager.instance.GetPlayerState(2);
        image.sprite = ImageKeep.instance.Images[state.image];
  
    }
    public void OnClick()
    {
        image = GetComponent<Image>();
        State state = StatesManager.instance.GetPlayerState(2);
        image.sprite = ImageKeep.instance.Images[state.image];

    }
}

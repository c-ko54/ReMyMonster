using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Image2PReflection : MonoBehaviour
{
    private Image image;
    void Start()
    {
        image = GetComponent<Image>();
        State state = StatesManager.instance.GetPlayerState(2);
        image.sprite = ImageKeep.instance.Images[state.image];
  
    }
}

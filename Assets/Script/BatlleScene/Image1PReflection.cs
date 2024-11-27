using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Image1PReflection : MonoBehaviour
{
    private Image image;
    void Start()
    {
        image = GetComponent<Image>();
        State state = StatesManager.instance.GetPlayerState(1);
        image.sprite = ImageKeep.instance.Images[state.image];

    }
}

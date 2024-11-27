using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageWindow : MonoBehaviour
{
    [SerializeField] GameObject a;
    private float TexX = 3650;
    private float TexY = -550;
    void Start()
    {
        transform.position = new Vector3(TexX, TexY, 0f);
    }

    public void WindowStart()
    {
        for (int i = 0; i <= 7300; i++)
        {
            TexX = TexX - 1;
            transform.position = new Vector3(TexX, TexY, 0f);
        }
    }


}

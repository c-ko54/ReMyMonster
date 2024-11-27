using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPosition : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject GO;
    void Start()
    {
        //CPU戦の進行度によってマップ上の立ち位置を変更する
        
        GO.transform.localScale = new Vector3(4.23087978f,2.37986994f,0.264429986f);
        if (GameManager.instance.CPUNUM == 1)
        {
            GO.transform.localPosition = new Vector3(100, -10, 0);
            GO.transform.localScale = new Vector3(2, 1.125f, 0.125f);
        }
        if (GameManager.instance.CPUNUM == 2)
        {
            GO.transform.localPosition = new Vector3(-85, -10, 0);
            GO.transform.localScale = new Vector3(1.5f, 0.84375f, 0.09375f);
        }
        if (GameManager.instance.CPUNUM == 3)
        {
            GO.transform.localPosition = new Vector3(12, 17, 0);
            GO.transform.localScale = new Vector3(1f,0.5625f,0.0625f);
        }
    }
}


using System.Collections.Generic;
using System.Collections;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;

public class csvReader : MonoBehaviour
{
    // Start is called before the first frame update
    // public TextAsset csvFile; // CSVファイル
    private string filePath;
    public List<string[]> csvDatas = new List<string[]>(); // CSVファイルの中身を入れるリスト 
    void Start()
    {
        #if UNITY_EDITOR
        filePath = @"Assets\Resources\Hint Save.csv";
        #else
        filePath = @"MyMonster2_Data\Resources\"+"Hint Save.csv";
        #endif



        if (GameManager.instance.FirstLoad == false)
        {
            // csvFile = Resources.Load(@"Hint save") as TextAsset; // Resouces下のCSV読み込み
            StreamReader reader = new StreamReader(filePath);
            while (reader.Peek() != -1) // reader.Peaekが-1になるまで
            {
                string line = reader.ReadLine(); // 一行ずつ読み込み
                csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
            }

            InList();
            GameManager.instance.FirstLoad = true;
        }

    }

    //CSVファイルからリストに入力
    void InList()
    {
        if (csvDatas.Count - 1 == 0)
        {
            return;
        }
        if (csvDatas[0][0] != "")
        {
            for (int i = 0; i < csvDatas.Count; i++)
            {
                int n = int.Parse(csvDatas[i][0]);
                GameManager.instance.GetHint.Add(n);
            }
        }
        if (csvDatas[0][1] != "")
        {
            int i = 0;
            while (csvDatas[i][1] != "")
            {
                int n = int.Parse(csvDatas[i][1]);
                GameManager.instance.GetHintEX.Add(n);
                i++;
                Debug.Log("ID : " + i);
            }
        }

    }
}

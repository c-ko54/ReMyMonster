using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.SceneManagement;
using System;

public class csvSave : MonoBehaviour
{
    private string filePath;
    public string Scene;


    private void Start()
    {
#if UNITY_EDITOR
        filePath = @"Assets\Resources\Hint Save.csv";
#else
        filePath = @"MyMonster2_Data\Resources\"+"Hint Save.csv";
#endif

    }

    public void WriteToFile(string data)
    {
        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, data + "\n", Encoding.UTF8);
        }
        else
        {
            string existingData = File.ReadAllText(filePath, Encoding.UTF8);
            if (!existingData.Contains(data))
            {
                File.AppendAllText(filePath, data + "\n", Encoding.UTF8);
            }
        }
    }

    public void WriteData()
    {
        // WriteToFile("\n");
        // WriteToFile("所持しているヒント,EX" + "\n");
        for (int i = 0; i < GameManager.instance.GetHint.Count; i++)
        {
            string EX = "";
            if (GameManager.instance.GetHintEX.Contains(i) == true)
            {
                EX = "" + GameManager.instance.GetHintEX[i];
            }
            else
            {
                EX = "";
            }
            WriteToFile(GameManager.instance.GetHint[i] + "," + EX);
        }
    }

    public void PushButtonExport()
    {
        WriteData();
    }

    public void PushButtonExportAndBack()
    {
        WriteData();
        if (Scene != "")
        {
            SceneManager.LoadScene(Scene);
        }

    }
}

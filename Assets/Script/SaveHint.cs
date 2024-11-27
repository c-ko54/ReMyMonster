using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class SaveHint : MonoBehaviour
{
    //csvファイルに書き込みしてセーブ
    public void Save()
    {
        
        StreamWriter file = new StreamWriter(@"C:\keep\MyMonster2\Assets\Resources\Hint Save.csv", false, Encoding.UTF8);

        for (int i = 0; i < GameManager.instance.GetHint.Count; i++)
        {
            //一行ずつ書き込み
            file.WriteLine(GameManager.instance.GetHint[i]);
        }

        file.Close();
    }
}

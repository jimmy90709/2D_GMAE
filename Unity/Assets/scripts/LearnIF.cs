using UnityEngine;

public class LearnIF : MonoBehaviour
{

    public bool test;
    public string prop;
    public int HP = 100;

    //更新事件:一秒執行 60 次
    private void Update()
    {
        #region  練習 if
        //判斷式 if 語法
        // if (布林植) { 陳述式或演算法 }
        // () 裡面的布林植為 true 才會執行
        if (test)
        {
            print("打開開關");
        }
        // () 裡面的布林植為 false 才會執行 else
        else
        {
            print("關閉開關~");
        }

        if(prop == "紅色藥水")
        {
            print("補血");
        }
        else if(prop == "藍色藥水")
        {
            print("補魔力");
        }
        else if(prop == "黃色藥水")
        {
            print("補體力");
        }
        else
        {
            print("沒發生任何事~");
        }
        #endregion

        if(HP>=70)
        {
            print("安全");
        }
        else if(HP>=50)
        {
            print("警告");
        }
        else if(HP>=20)
        {
            print("危險");
        }
        else if(HP>0)
        {
            print("快死了");
        }
        else
        {
            print("大俠勝敗乃兵家常事~ 請重新來過");
        }
    }
}

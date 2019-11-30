using UnityEngine;
using UnityEngine.UI;                 // 引用 介面 API
using UnityEngine.SceneManagement;    // 引用 場景管理 API

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int lv;
    [Header("最高分數")]
    public int high;
    [Header("水管")]
    //GameObject 可以存放場景上的遊戲物件與專案內的預置物
    public GameObject pipe;
    [Header("遊戲結算畫面")]
    public GameObject goFinal;
    [Header("分數介面")]
    public Text textScore;
    public Text textBest;
    
    //static 不會顯示在屬性 Inspector 面板上
    public static bool gameOver;

    //修飾詞權限:
    //private 其他類別無法使用
    //public  其他類別可以使用

   /// <summary>
   /// 加分
   /// </summary>
   public void plus()
   {
        print("加分~");
        lv++;
        // 分數介面.文字內容 = 分數.轉為字串()
        // ToString() 可以將任何類型轉為字串
        textScore.text = lv.ToString();

        //呼叫最佳分數判定
        HeightScore();
   }

   /// <summary>
   /// 最高分數判定
   /// </summary>
   private void HeightScore()
   {
      // 如果 目前分數 > 最佳分數
      if(lv > PlayerPrefs.GetInt("最佳分數"))
        {
            //玩家資料.設定整數("最佳分數", 目前分數)
            PlayerPrefs.SetInt("最佳分數", lv);
        }
    }

   /// <summary>
   /// 生成水管
   /// </summary>
   private void SpawnPipe()
   {
      print("生水管~");
      //生成(物件)
      //Instantiate(pipe);

      // 生成(物件，坐標，角度)
      //區域欄位(不需要修飾詞)
      float y = Random.Range(-1f,1.5f);
      Vector3 pos = new Vector3(10,y,0);

      //Quaternion.identity 代表零角度
      Instantiate(pipe,pos,Quaternion.identity);
   }

   /// <summary>
   /// 遊戲結束
   /// </summary>
   public void GameOver()
   {
        goFinal.SetActive(true);     // 顯示結算畫面
        gameOver = true;             // 遊戲結束 = 是
        CancelInvoke("SpawnPipe");   // 停止 InvokeRepeating、Invoke
   }

    //要給 UI 按鈕呼叫的方法必須是 public

    /// <summary>
    /// 重新遊戲
    /// </summary>
    public void Replay()
    {
        //Application.LoadLevel("遊戲場景");   // 應用程式.載入場景("場景名稱"); 舊版 API
        SceneManager.LoadScene("遊戲場景");    // 場景管理器.載入場景("場景名稱"); 新版API
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Quit()
    {
        Application.Quit();   //  使用 應用程式.離開();
    }
    private void Start()
   {
        // 螢幕.設定解析度(寬, 高 是否全螢幕)
        Screen.SetResolution(720, 1280, false);
        //靜態成員再載入場景都不會還原
        gameOver = false;
       // 重複調用("方法名稱" , 開始時間, 間隔時間)
       InvokeRepeating("SpawnPipe", 0, 2f);
        textBest.text = PlayerPrefs.GetInt("最佳分數").ToString();
   }
}

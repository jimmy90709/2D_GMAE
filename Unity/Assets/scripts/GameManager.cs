using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int lv;
    [Header("最高分數")]
    public int high;
    [Header("水管")]
    //GameObject 可以存放場景上的遊戲物件與專案內的預置物
    public GameObject pipe;

    //修飾詞權限:
    //private 其他類別無法使用
    //public  其他類別可以使用

   /// <summary>
   /// 加分
   /// </summary>
   public void plus()
   {
      
   }

   /// <summary>
   /// 最高分數判定
   /// </summary>
   private void HeightScore()
   {
      
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
      float y = Random.Range(-2f,3f);
      Vector3 pos = new Vector3(10,y,0);

      //Quaternion.identity 代表零角度
      Instantiate(pipe,pos,Quaternion.identity);
   }

   /// <summary>
   /// 遊戲結束
   /// </summary>
   public void GameOver()
   {
      
   }

   private void Start()
   {
       // 重複調用("方法名稱" , 開始時間, 間隔時間)
       InvokeRepeating("SpawnPipe", 0, 1.5f);
   }
}

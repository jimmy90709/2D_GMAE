using UnityEngine;

public class Ground : MonoBehaviour
{
   //宣告變數(定義蘭為 field)
   //private 私人(隱藏) pubilc 公開(顯示)
   public int speed = 20;

   public Transform ground;

      private void Start() 
   {
      //屬性
      print(ground.position);
   }

   private void Update() 
   {
      //呼叫方法
      Move();
   }

   //方法 / 函式 Method / function 語法 :
   //修飾詞 方法類型 方法名稱() {陳述式(敘述、演算法)}
   //void 無法回傳類型
   /// <summary>
   /// 地板的移動方法。
   /// </summary>
   private void Move()
   {
      // 如果 GM.遊戲結束 為 勾選 就 跳出
      if (GameManager.gameOver) return;
      //地板.位移(x,y,z);
      //Time.deltaTime 每幀的時間
      ground.Translate(-speed * Time.deltaTime, 0, 0);
   }
}

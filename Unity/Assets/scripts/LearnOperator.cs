using UnityEngine;

public class LearnOperator : MonoBehaviour
{
   public int a = 10, b = 3, c = 10, d = 10;
   public int score = 50;
   public int num1 = 90, num2 = 10;

   public bool boolA = true,boolB = false;

   private void Start() 
   {
      #region 數學運算區域
      //數學運算
      print(a + b);   //13
      print(a - b);   //7
      print(a * b);   //30
      print(a / b);   //3
      print(a % b);   //10 / 3 = 3...1

      //遞增 ++ 、遞減 --
      print(c++);     //先輸出再執行遞增
      print(++d);     //先執行遞增再輸出

      //指定運算 : 等號右邊會先運算再傳給左邊
      score = score + 10;  //等於 score += 10;
      #endregion

      #region 比較運算
      //比較運算(結果為布林值)
      print(num1 > num2);
      print(num1 < num2);
      print(num1 >= num2);
      print(num1 <= num2);
      print(num1 == num2);
      print(num1 != num2);
      #endregion

      #region 邏輯運算
      //邏輯運算
      //並且 &&
      print(boolA && boolB);   //只要有一個 false 結果為 false
      //或者 ||
      print(boolA || boolB);   //只要有一個 true 結果為 true
      //相反
      print(!true);   //f
      print(!false);  //t
      #endregion
   }
}

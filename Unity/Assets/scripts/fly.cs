using UnityEngine;

public class fly : MonoBehaviour
{
    [Header("跳躍高度"),Range(10,2000)]
    public int jump = 100;
    [Header("是否死亡"),Tooltip("死亡為 true,還存活 false")]
    public bool s;

    /// <summary>
   /// 小雞跳躍
   /// </summary>
   private void Jump()
   {
      
   }

    /// <summary>
   ///  小雞死亡
   /// </summary>
   private void death()
   {
      
   }
}

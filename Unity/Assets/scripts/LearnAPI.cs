using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public Transform transformA;
    public Transform transformB;
    public Camera depthA;

    private void Start()
    {
         // 使用靜態成員 - 屬性
         print("隨機 :" + Random.value);
        
         //使用靜態成員 數學類別.PI (Mathf)
         print("PI:" + Mathf.PI);

         // 使用靜態成員 - 方法
          print("隨機範圍:" + Random.Range(0,100));

          print("絕對值:" + Mathf.Abs(-99));

          //非靜態成員
          //需要先給予蘭為存放時體物件
          print("物件 A 的座標:" + transformA.position);
        
          transformB.position = new Vector3(-2,0,0);
          print("物件 B 的座標:" + transformB.position);

          print("攝影機深度:" + depthA.depth);

    }
     private void Update()
    {
        //非靜態成員 - 方法
        transformB.Rotate(0,0,10);
    }
}

using UnityEngine;

public class fly : MonoBehaviour
{
    [Header("跳躍高度"),Range(10,2000)]
    public int jump = 200;
    [Header("旋轉角度"), Range(0, 100)]
    public float angle = 10;
    [Header("是否死亡"),Tooltip("死亡為 true,還存活 false")]
    public bool dead;
    [Header("剛體")]
    public Rigidbody2D r2d;
    [Header("遊戲處理器")]
    public GameManager gm;

    public GameObject goScore, goGM;
    //AudioSource 存放喇吧元件
    //AudioClip 存放音效檔案
    public AudioSource aud;
    public AudioClip soundJump, soundHit, soundAdd;

    /// <summary>
   /// 小雞跳躍
   /// </summary>
   private void Jump()
   {
      //if(dead == true)
      //  {
      //      return;
      //  }

      // 如果 死亡 跳出此程式區塊
      if (dead) return;  //簡寫

      // 如果 玩家 按下 左鍵
      //輸入.按下按鍵(按鍵列舉.滑鼠左鍵) (手機觸控)
      if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("玩家按下左鍵~");
            aud.PlayOneShot(soundJump, 1.5f);
            r2d.Sleep();
            r2d.gravityScale = 1;                //小雞鋼體.重力 = 1;
            r2d.AddForce(new Vector2(0,jump));   //小雞鋼體.增加推力(二維向量(左右，上下));
            goScore.SetActive(true);             // 分數 顯示
            goGM.SetActive(true);                // GM   顯示
        }
      if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            r2d.gravityScale = 2;
        }

        //Rigidbody2D.SetRotation(float) 設定角度(角度)
        //Rigidbody2D.velocity 加速度 (二維向量 x, y)
        r2d.SetRotation(angle * r2d.velocity.y);
    }

    /// <summary>
   ///  小雞死亡
   /// </summary>
   private void Dead()
   {
        print("死亡~");
        aud.PlayOneShot(soundHit, 1.5f);
        dead = true;
        gm.GameOver();
   }
    //固定幀數 0.002 一幀:要控制物理請寫在此事件內
    private void FixedUpdate()
    {
        Jump();
    }

    //事件: 碰撞開始 - 碰撞開始時執行一次 (Collision2D collision) (碰撞類別 名稱
    private void OnCollisionEnter2D(Collision2D hit)
    {
        //碰到物件.遊戲物件.名稱
        print(hit.gameObject.name);
        if (hit.gameObject.name == "地板")
        {
            Dead();
        }
    }

    //事件 : 觸發開始 - 物件必須勾選 IsTrigger
    private void OnTriggerEnter2D(Collider2D hit)
    {
        //Trigger 可以省略 gameObject
        //如果 碰到.物件名稱 為 上 或者 下 - 死亡
        if(hit.gameObject.name == "水管(向上)" || hit.gameObject.name == "水管 (向下)")
        {
            Dead();
        }
    }

    //事件 : 觸發離開 - 物件離開觸發區域執行一次
    private void OnTriggerExit2D(Collider2D hit)
    {
        // dead != true  簡寫 !dead
        if (hit.name == "加分" && dead != true)
        {
            aud.PlayOneShot(soundAdd, 1.5f);
            aud.PlayOneShot(soundAdd, 0.7f);
            gm.plus();
        }
    }
}

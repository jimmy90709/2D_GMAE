//繼承: 可以享有繼承類別的成員
public class Pipe : Ground
{
   private void Start()
   {
       // gameObject 指的是此類別的遊戲物件
       // 刪除(物件 ， 延遲時間)
       Destroy(gameObject, 3f);
   }
}

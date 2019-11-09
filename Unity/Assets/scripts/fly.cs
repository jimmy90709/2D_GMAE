using UnityEngine;

public class fly : MonoBehaviour
{
    [Header("跳躍高度"),Range(10,2000)]
    public int jump = 100;
    [Header("是否死亡"),Tooltip("死亡為 true,還存活 false")]
    public bool s;
}

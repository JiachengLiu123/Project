using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public delegate void PlayerScore(int temp);//定义委托
    public event PlayerScore GetScore;//定义得分事件，用于发出得分的消息
    void Start()
    {

    }

    public void OnTriggerExit(Collider other)//设置触发器碰撞事件，一旦Player穿过了gold,就发送得分事件
    {
        if (other.gameObject.name.Equals("gold"))//检查Player碰撞的物体是不是gold
        {
            if (GetScore != null)//检查事件是否为空，即有没有接收器订阅它
            {
                GetScore(1);//发送得分事件消息，为接收器提供参数1，实现+1分的效果
            }
        }
    }
}
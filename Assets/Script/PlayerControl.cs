using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public delegate void PlayerScore(int temp);//定义委托
    public event PlayerScore GetScore;//定义得分事件，用于发出得分的消息

    private Rigidbody rd;

    void Start()
    {
        rd = GetComponent<Rigidbody>();//获得物体的刚体组件
    }
    float speed = 10.0f;   //移动速度
    float rotationSpeed = 100.0f;  //旋转速度
    // Update is called once per frame
    void Update()
    {
        // 使用上下方向键或者W、S键来控制前进后退
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //使用左右方向键或者A、D键来控制左右旋转
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation); //沿着Z轴移动
        transform.Rotate(0, rotation, 0); //绕Y轴旋转
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
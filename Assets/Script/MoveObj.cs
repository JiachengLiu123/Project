using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    private Rigidbody rd;
    void Start()
    {
        rd = GetComponent<Rigidbody>();//�������ĸ������
    }
    float speed = 10.0f;   //�ƶ��ٶ�
    float rotationSpeed = 100.0f;  //��ת�ٶ�
    // Update is called once per frame
    void Update()
    {
        // ʹ�����·��������W��S��������ǰ������
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //ʹ�����ҷ��������A��D��������������ת
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation); //����Z���ƶ�
        transform.Rotate(0, rotation, 0); //��Y����ת
    }

}

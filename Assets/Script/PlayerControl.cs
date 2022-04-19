using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public delegate void PlayerScore(int temp);//����ί��
    public event PlayerScore GetScore;//����÷��¼������ڷ����÷ֵ���Ϣ

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


public void OnTriggerExit(Collider other)//���ô�������ײ�¼���һ��Player������gold,�ͷ��͵÷��¼�
    {
        if (other.gameObject.name.Equals("gold"))//���Player��ײ�������ǲ���gold
        {
            if (GetScore != null)//����¼��Ƿ�Ϊ�գ�����û�н�����������
            {
                GetScore(1);//���͵÷��¼���Ϣ��Ϊ�������ṩ����1��ʵ��+1�ֵ�Ч��
            }
        }
    }
}
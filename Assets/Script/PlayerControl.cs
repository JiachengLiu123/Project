using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public delegate void PlayerScore(int temp);//����ί��
    public event PlayerScore GetScore;//����÷��¼������ڷ����÷ֵ���Ϣ
    void Start()
    {

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
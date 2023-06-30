using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemytest : MonoBehaviour
{
    private GameObject enemy ;  //�لӤ����������֥������Ȥ򥤥󥹥ڥ����`�������롣
    public int Espeed = 5;  //���֥������Ȥ��ԄӤǄӤ����ԩ`���{��
    Vector3 movePosition;  //�ڥ��֥������Ȥ�Ŀ�ĵؤ򱣴�
    public int targetx1;
    public int targety1;
    public int targetx2;
    public int targety2;

    void Start()
    {
        movePosition = MoveRandomPosition();  //�ڌg�Еr�����֥������Ȥ�Ŀ�ĵؤ��O��
        enemy = this.gameObject;
    }

    void Update()
    {
        if (movePosition == enemy.transform.position)  //��player���֥������Ȥ�Ŀ�ĵؤ˵��_����ȡ�
        {
            movePosition = MoveRandomPosition();  //��Ŀ�ĵؤ����O��
        }
        this.enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, movePosition, Espeed * Time.deltaTime);  //�٢�player���֥������Ȥ�, Ŀ�ĵؤ��Ƅ�, �Ƅ��ٶ�
    }

    private Vector3 MoveRandomPosition()  // Ŀ�ĵؤ����ɡ�x��y�Υݥ������������˂���ȡ�� 
    {
        Vector3 randomPosi = new Vector3(Random.Range(targetx1, targetx2), Random.Range(targety1, targety2), 0);
        return randomPosi;
    }
}


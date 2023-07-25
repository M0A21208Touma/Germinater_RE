using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public GameObject player;   //�@�ړ����������I�u�W�F�N�g
    private StopMove sm;
    private SpilitAction sa;
    private SearchErea se;
    private Quaternion initialRotation; // �����̉�]
    private bool isSee = false;
    //public GameObject PlayerView;
    /* [SerializeField]
     ClickToVisualize ctv;*/

    private void Start()
    {
        //ctv.spilit.transform.position = player.transform.position;
        //ctv = FindObjectOfType<ClickToVisualize>();
        sm = FindObjectOfType<StopMove>();
        sa = FindObjectOfType<SpilitAction>();
        se = FindObjectOfType<SearchErea>();
        // �����̉�]��ۑ�
    }


    void Update()
    {
        /*if (ctv.isView == true && sm.isStop == false)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, ctv.spilit.transform.position, speed * Time.deltaTime);
            Vector3 toDirection = ctv.spilit.transform.position - player.transform.position;
            // �Ώە��։�]����
            transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);//player�I�u�W�F�N�g��, �ړI�n�Ɉړ�, �ړ����x//player�I�u�W�F�N�g��, �ړI�n�Ɉړ�, �ړ����x
        }*/
        if (se.isFlower == true)
        {
            Vector3 toDirection = se.FlowerPosition - player.transform.position;
            // �Ώە��։�]����
            transform.rotation = Quaternion.FromToRotation(Vector3.right, toDirection);

            isSee = true;
        }
        else if (se.isEnemy == true)
        {
            Vector3 toDirection = player.transform.position - sa.mousePosition;
            // �Ώە��։�]����
            transform.rotation = Quaternion.FromToRotation(Vector3.right, toDirection);

            isSee = true;
        }
        else if (sa.isView == true && sm.isStop == false)
        {
            Vector3 toDirection = sa.mousePosition - player.transform.position;
            // �Ώە��։�]����
            transform.rotation = Quaternion.FromToRotation(Vector3.right, toDirection);

            isSee = false;
        }
        else
        {

        }
        /*else
        {
            Vector3 toDirection = sa.mousePosition - player.transform.position;
            // �Ώە��։�]����
            transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);//player�I�u�W�F�N�g��, �ړI�n�Ɉړ�, �ړ����x//player�I�u�W�F�N�g��, �ړI�n�Ɉړ�, �ړ����x
        }*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public static int speed;
    public GameObject player;   //�@�ړ����������I�u�W�F�N�g
    //Vector3 touchWorldPosition;�@//�A�}�E�X�Ń^�b�`�����ӏ��̍��W���擾
    //public GameObject currentObject; // ���ݐ�������Ă���I�u�W�F�N�g
    //public GameObject pointObject;
    //private ClickToVisualize ctv;
    private StopMove sm;
    private SpilitAction sa ;
    private SearchErea se;
    public Transform targetObject; // ��]���Œ肷��q�I�u�W�F�N�g��Transform
    private Quaternion initialRotation; // �����̉�]
    public GameObject odoroki;
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
        initialRotation = targetObject.rotation;
        speed = 5;
        odoroki.SetActive(false);
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
            player.transform.position = Vector3.MoveTowards(player.transform.position, se.FlowerPosition, speed * Time.deltaTime);
            Vector3 toDirection = se.FlowerPosition - player.transform.position;
            // �Ώە��։�]����
            transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);

            StartCoroutine(ActivateOdoroki());
            isSee = true;
        }
        else if (se.isEnemy == true)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, sa.mousePosition, speed * Time.deltaTime);
            Vector3 toDirection =  player.transform.position - sa.mousePosition;
            // �Ώە��։�]����
            transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);
            StartCoroutine(ActivateOdoroki());
            isSee = true;
        }
        else if (sa.isView == true && sm.isStop == false)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, sa.mousePosition, speed * Time.deltaTime);
            Vector3 toDirection = sa.mousePosition - player.transform.position;
            // �Ώە��։�]����
            transform.rotation = Quaternion.FromToRotation(Vector3.up, toDirection);

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
    private void LateUpdate()
    {
        // �q�I�u�W�F�N�g�̉�]�������̉�]�ɐݒ�
        targetObject.rotation = initialRotation;
    }
    private IEnumerator ActivateOdoroki()
    {
        if (isSee == false)
        {
            odoroki.SetActive(true);  // odoroki���A�N�e�B�u�ɂ���

            yield return new WaitForSeconds(1f);  // 1�b�҂�

            odoroki.SetActive(false);  // odoroki���A�N�e�B�u�ɂ���
        }
     }
}
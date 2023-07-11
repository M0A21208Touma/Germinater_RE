using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpilitAction : MonoBehaviour
{
    private Camera mainCamera;
    public bool isView;
    public Vector3 mousePosition;
    //public bool isAttack;
    public int count;
    public Vector3 currentPosition;
    public int attackspeed = 5;
    public GameObject magic_g;
    //public GameObject Wind;
    public GameObject Girl;
    public float delaySeconds = 3f;
    //public GameObject followSp;
    //public GameObject AttackSp;
    public float rapidTime;	//      ���t���[�����Ԃ�������Ă�����
    public float rapid;                                 //�@�{�[�����o����悤�ɂȂ�܂ł̎��ԁ@float�^�̕ϐ���p�ӂ��܂�
    public float oriRapid;                         //�@����rapid�ɓ�����Ă����l���i�[���Ă����ϐ��@ float�^�̕ϐ���p��

    private List<Vector3> attackPoints = new List<Vector3>();  // �N���b�N�����ʒu��ۑ�����z��
    private List<GameObject> clones = new List<GameObject>();  // ������������ۑ�����z��
    private List<GameObject> windClones = new List<GameObject>();  // ��������Wind�I�u�W�F�N�g��ۑ�����z��
    public static bool isShoot;

    private void Start()
    {
        mainCamera = Camera.main;
        isView = false;
        //isAttack = false;
        count = 0;
        //followSp.SetActive(false);
        //AttackSp.SetActive(false);
        oriRapid = rapid;             //editor��rapid�ɓ��ꂽ�l��oriRapid�Ɋi�[���܂�
        isShoot = false;
    }

    private void Update()
    {
        mousePosition = GetMouseWorldPosition();
        oriRapid -= rapidTime;                                   //�ϐ�oriRapid����ϐ�rapidTime�̒l�������āA�܂��ϐ�oriRapid�ɖ߂��܂�
        //�d���̓���
        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        //currentPosition = transform.position;

        //���̋��ˏo
        if (Input.GetMouseButtonDown(0))  // ���N���b�N
        {
            //transform.position = currentPosition;
            //attackPoints.Add(mousePosition);  // �N���b�N�����ʒu��z��ɒǉ�
            if (oriRapid <= 0.0f == true)     //����rapid�̒l���O�ȉ��ɂȂ�����A�}�E�X�{�^�������������ɒe���o��悤�ɂȂ�܂�
            {
                GameObject clone = Instantiate(magic_g, this.transform.position, Quaternion.identity);
                //clones.Add(clone);  // ������������z��ɒǉ�

                // �����̐����iZ�����̏����Ɛ��K���j
                Vector3 shotForward = Vector3.Scale((mousePosition - Girl.transform.position), new Vector3(1, 1, 0)).normalized;

                // �e�ɑ��x��^����
                clone.GetComponent<Rigidbody2D>().velocity = shotForward * attackspeed;
                oriRapid = rapid;               //�@ rapid�Ɍ��̒l�����Ė߂��܂��@

                // 2�b���clone���폜����
                Destroy(clone, 2f);
                isShoot = true;
            }
        }
       
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        
        if(other.gameObject.tag == "Start")
        {
            Time.timeScale = 1f;
            Debug.Log("ddd");
        }
        else if (other.gameObject.tag == "View")
        {
            isView = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "View")
        {
            isView = false;
        }
    }
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -mainCamera.transform.position.z;
        return mainCamera.ScreenToWorldPoint(mousePosition);
    }
}

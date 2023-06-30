using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpilitAction : MonoBehaviour
{
    private Camera mainCamera;
    public bool isView;
    public Vector3 mousePosition;
    public bool isAttack;
    public int count;
    public Vector3 currentPosition;
    public int attackspeed = 5;
    public GameObject magic_g;
    public GameObject Wind;
    public float delaySeconds = 3f;
    public GameObject followSp;
    public GameObject AttackSp;

    private List<Vector3> attackPoints = new List<Vector3>();  // �N���b�N�����ʒu��ۑ�����z��
    private List<GameObject> clones = new List<GameObject>();  // ������������ۑ�����z��
    private List<GameObject> windClones = new List<GameObject>();  // ��������Wind�I�u�W�F�N�g��ۑ�����z��

    private void Start()
    {
        mainCamera = Camera.main;
        isView = false;
        isAttack = false;
        count = 0;
        followSp.SetActive(false);
        AttackSp.SetActive(false);
    }

    private void Update()
    {
        mousePosition = GetMouseWorldPosition();
        if (Input.GetMouseButtonDown(1))  // �E�N���b�N
        {
            count += 1;
        }

        if (count == 0)  // ���삪�}�E�X�Ǐ]
        {
            isAttack = false;
        }
        else if (count == 1)
        {
            isAttack = true;
        }
        else
        {
            count = 0;
        }

        if (isAttack == false)
        {
            AttackSp.SetActive(false);
            followSp.SetActive(true);
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
            currentPosition = transform.position;
        }
        else if (isAttack == true)
        {
            followSp.SetActive(false);
            AttackSp.SetActive(true);
            if (Input.GetMouseButtonDown(0))  // ���N���b�N
            {
                transform.position = currentPosition;
                attackPoints.Add(mousePosition);  // �N���b�N�����ʒu��z��ɒǉ�

                GameObject clone = Instantiate(magic_g, this.transform.position, Quaternion.identity);
                clones.Add(clone);  // ������������z��ɒǉ�

                // �����̐����iZ�����̏����Ɛ��K���j
                Vector3 shotForward = Vector3.Scale((mousePosition - this.transform.position), new Vector3(1, 1, 0)).normalized;

                // �e�ɑ��x��^����
                clone.GetComponent<Rigidbody2D>().velocity = shotForward * attackspeed;
            }
        }
        for (int i = 0; i < clones.Count; i++)
        {
            if (clones[i] != null)
            {
                if (Vector3.Distance(attackPoints[i], clones[i].transform.position) < 0.1f)
                {
                    GameObject windClone = Instantiate(Wind, attackPoints[i] + new Vector3(0, 0, 10), Quaternion.identity);
                    windClones.Add(windClone);  // ��������Wind�I�u�W�F�N�g��z��ɒǉ�

                    Destroy(clones[i]);
                    clones.RemoveAt(i);
                    attackPoints.RemoveAt(i);
                    Destroy(windClone, delaySeconds);
                    windClones.Remove(windClone);
                }
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

using UnityEngine;

public class ClickToVisualize : MonoBehaviour
{
    public GameObject spilit;
    //private GameObject spilit;
        // ���ݐ�������Ă���I�u�W�F�N�g
    public GameObject player;   //�@�ړ����������I�u�W�F�N�g
    public int speed = 3;
    public GameObject magic_r;
    private Vector3 attackPoint;
    private GameObject clone;
    public GameObject Wind;
    private GameObject Windclone;
    // public float Magicspeed;
    public bool isView;
    public float delaySeconds = 3f;  // �j��܂ł̑ҋ@���ԁi�b�j
    public Vector3 mouseWorldPos;

    void Start()
    {
        spilit = Instantiate(spilit, player.transform.position, Quaternion.identity);

        //Magicspeed = 10.0f;  // �e�̑��x
        isView = false;

    }

    void Update()
    {
       if (Input.GetMouseButtonDown(1))  //�E�N���b�N��if���N��
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitInfo = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hitInfo.collider.tag == "Ground")
            {
                Vector3 clickPoint = hitInfo.point;
                // �ȑO�ɐ������ꂽ�I�u�W�F�N�g������΍폜����
                if (spilit != null)
                {
                    Destroy(spilit);
                }
                //clickPoint.z = 10.0f;  //�A���s����O�ɗ���悤��5.0f���w��B
                //Camera camera = Camera.main;  //�A
                //touchWorldPosition = camera.ScreenToWorldPoint(clickPoint);  //�A
                // �V�����I�u�W�F�N�g�𐶐�����
                spilit = Instantiate(spilit, clickPoint, Quaternion.identity);
                isView = false;
            }
            else if (hitInfo.collider.tag == "View")
            {
                Vector3 clickPoint = hitInfo.point;
                if (spilit != null)
                {
                    Destroy(spilit);
                }
                spilit = Instantiate(spilit, clickPoint, Quaternion.identity);
                isView = true;
            }
        }
           

        if (Input.GetMouseButtonDown(0)) //���N���b�N
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitInfo = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hitInfo.collider.tag == "Ground" || hitInfo.collider.tag == "View")
            {
               attackPoint = hitInfo.point;
                // �e�i�Q�[���I�u�W�F�N�g�j�̐���
                //attackPoint.z = 5.0f;//Magic_r�̕ʂ̃X�N���v�g�����K�v����
                clone = Instantiate(magic_r, spilit.transform.position, Quaternion.identity);

                // �N���b�N�������W�̎擾�i�X�N���[�����W���烏�[���h���W�ɕϊ��j
            mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                // �����̐����iZ�����̏����Ɛ��K���j
                Vector3 shotForward = Vector3.Scale((mouseWorldPos - spilit.transform.position), new Vector3(1, 1, 0)).normalized;

                // �e�ɑ��x��^����(�v����)
                clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;
            }       
        }
        /*if (Vector3.Distance(clone.transform.position, mouseWorldPos) < 0.1f)
        {
            Debug.Log("aaa");
            Destroy(clone);
            Wind = Instantiate(Wind, mouseWorldPos, Quaternion.identity);
            Destroy(Wind, delaySeconds);
        }*/
        if (clone != null)
        {
            if (Vector3.Distance(attackPoint, clone.transform.position) < 0.1f)
            {
                clone.SetActive(false);
                Destroy(clone);
                Windclone = Instantiate(Wind, mouseWorldPos + new Vector3 (0,0,10), Quaternion.identity);
                Destroy(Windclone, delaySeconds);
            }
        }
        //player.transform.position = Vector3.MoveTowards(player.transform.position, spilit. transform.position, speed * Time.deltaTime); //player�I�u�W�F�N�g��, �ړI�n�Ɉړ�, �ړ����x
    }
}


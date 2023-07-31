using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    //������ȥ��å�
    private float countup = 0.0f;
    //�������ߥå�
    public GameObject ritsu;
    public Text ritsuSelf;
    public SpriteRenderer black;
    public SpriteRenderer white;
    public Animator ritsuAnim;
    public float fadeTime = 0.5f;
    private float time;
    public float toumeido = 0;
    public float toumeido2 = 0;
    public GameObject shijieshu1;
    public GameObject shijieshu3;
    public GameObject logo;
    public GameObject logo2;


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(countup);
        //�r�g�򥫥���Ȥ���
        countup += Time.deltaTime;

        Transform myTransform = ritsu.transform;
        Vector3 pos = myTransform.position;
        if (countup <= 3.3f)
        {
            pos.x += 0.01f;
            myTransform.position = pos;  // ���ˤ��O��
        }
        if (countup > 4.0f)
        {
            ritsuAnim.SetBool("isWalk_R", false);
            ritsuAnim.SetBool("isWalk_L", false);
            ritsuAnim.SetBool("isWalk_B", false);
            ritsuAnim.SetBool("isWalk_F", false);
            ritsuAnim.SetBool("isStop_R", true);
            ritsuAnim.SetBool("isStop_L", false);
            ritsuAnim.SetBool("isStop_F", false);
            ritsuAnim.SetBool("isStop_B", false);
        }
        if (countup > 4.5f&&countup<6f)
        {
            time += Time.deltaTime;
            float alpha = 1.0f - time / fadeTime;
            Color color = white.color;
            color.a = alpha;
            white.color = color;
            ritsuSelf.text = "����������˽��˼����������";
        }

        if (countup > 6f && countup <10.5f)
        {
            if (toumeido < 255f)
            {
                toumeido += 1f;
            }
            white.color = new Color32(255, 255, 255, (byte)toumeido);
            if (toumeido >= 255f)
            {
                ritsuSelf.color = new Color32(0, 0, 0, 255);
                ritsuSelf.text = "˽���������Ӥ���\n����䤫����Ѥ��졢���g������һ�w��������ͤ�A���Ƥ���";
            }

        }
        if (countup >= 10.5f)
        {

            ritsuSelf.text = "���ɡ�˽����뤿��ˤ��������������ޤä�\n�����R�����ߤ��졢����¤ˤʤä�";
        }
        if (countup > 15f && countup < 18f)
        {
            ritsuSelf.color = new Color32(255, 255, 255, 255);
            ritsuSelf.text = "�񤳤���˽����Ŀ���������r��";
            shijieshu1.SetActive(true);
            Destroy(white.gameObject);
        }
        if (countup > 18f)
        {
           
            ritsuSelf.text = "�Ǥ�..���Θ��Ӥ�Ҋ��ȡ������Ϥ⤦...\n���㡢˽�����٤Ƥ��������ޤ��礦��";
            shijieshu3.SetActive(true);
        }
        if (countup > 23f)
        {
           
            ritsuSelf.text = "����ƣ�옔�Ǥ�������䤵�󡣡�\n���񤫤�˽����������Ȼ���ؤ뤫��...��";
            if (toumeido2 < 255f)
            {
                toumeido2 += 1f;
            }
            black.color = new Color32(0, 0, 0, (byte)toumeido2);
            if (toumeido2 >= 255f&& countup > 27f)
            {
         
                ritsuSelf.text = "�������󡢥�åȤ�һ�w�ˤͤ�����";
            }
        }
        if (countup > 32f)
        {
            ritsuSelf.text = "End";
            logo.SetActive(true);
        }
        if (countup > 36f)
        {
            ritsuSelf.text = " ";
            logo2.SetActive(true);
        }
        if (countup > 40f)
        {
            SceneManager.LoadScene("TitleScene", LoadSceneMode.Single);
        }
    }
}
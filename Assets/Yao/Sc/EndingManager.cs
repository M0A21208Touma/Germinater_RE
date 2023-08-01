using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    //�J�E���g�A�b�v
    private float countup = 0.0f;
    //�^�C�����~�b�g
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
        //���Ԃ��J�E���g����
        countup += Time.deltaTime;

        Transform myTransform = ritsu.transform;
        Vector3 pos = myTransform.position;
        if (countup <= 3.3f)
        {
            pos.x += 0.01f;
            myTransform.position = pos;  // ���W��ݒ�
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
        if (countup > 4.5f && countup < 6f)
        {
            time += Time.deltaTime;
            float alpha = 1.0f - time / fadeTime;
            Color color = white.color;
            color.a = alpha;
            white.color = color;
            ritsuSelf.text = "�u�������A�v���o�����B�v";
        }

        if (countup > 6f && countup < 11.5f)
        {
            if (toumeido < 255f)
            {
                toumeido += 1f;
            }
            white.color = new Color32(255, 255, 255, (byte)toumeido);
            if (toumeido >= 255f)
            {
                ritsuSelf.color = new Color32(0, 0, 0, 255);
                ritsuSelf.text = "���͐��E���̎q�@\n���E�����番�􂳂�A�l�Ԃ����ƈꏏ�ɐ����𑗂葱���Ă����B";
            }

        }
        if (countup >= 11.5f)
        {

            ritsuSelf.text = "����ǁA���𑢂邽�߂ɐ��E���̗͂���܂���\n���ӎ����\�����āA��S���ɂȂ���";
        }
        if (countup > 16f && countup < 19f)
        {
            ritsuSelf.color = new Color32(255, 255, 255, 255);
            ritsuSelf.text = "�ł�..���̗l�q������ƁA���E���͂���..";
            ritsuAnim.SetBool("isWalk_R", false);
            ritsuAnim.SetBool("isWalk_L", false);
            ritsuAnim.SetBool("isWalk_B", false);
            ritsuAnim.SetBool("isWalk_F", false);
            ritsuAnim.SetBool("isStop_R", true);
            ritsuAnim.SetBool("isStop_L", false);
            ritsuAnim.SetBool("isStop_F", false);
            ritsuAnim.SetBool("isStop_B", false);
            ritsuAnim.SetBool("isStop", false);
            shijieshu1.SetActive(true);
            Destroy(white.gameObject);
        }
        if (countup >= 19f)
        {

            ritsuSelf.text = "�������A���̖�ڂ��ʂ������@\n����A�������ׂĂ��z�����܂��傤�I";
            shijieshu3.SetActive(true);
        }
        if (countup > 24f)
        {

            ritsuSelf.text = "�u�����l�ł��A���E������B�v\n�u���ꂩ�玄������Ɏ��R����邩��...�v";
            if (toumeido2 < 255f)
            {
                toumeido2 += 1f;
            }
            black.color = new Color32(0, 0, 0, (byte)toumeido2);
            if (toumeido2 >= 255f && countup > 28f)
            {

                ritsuSelf.text = "�u�������A���b�g���ꏏ�ɂˁv";
            }
        }
        if (countup > 33f)
        {
            ritsuSelf.text = "End";
 
        }
        if (countup > 37f)
        {
            ritsuSelf.text = " ";
            logo.SetActive(true);
            logo2.SetActive(true);
        }
        if (countup > 40f)
        {
            SceneManager.LoadScene("TitleScene", LoadSceneMode.Single);
        }
    }
}
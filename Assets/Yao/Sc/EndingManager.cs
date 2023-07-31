using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    //カウントアップ
    private float countup = 0.0f;
    //タイムリミット
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
        //�r�gをカウントする
        countup += Time.deltaTime;

        Transform myTransform = ritsu.transform;
        Vector3 pos = myTransform.position;
        if (countup <= 3.3f)
        {
            pos.x += 0.01f;
            myTransform.position = pos;  // 恙�砲鰓O協
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
            ritsuSelf.text = "仝そうだ、暴は房い竃した々";
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
                ritsuSelf.text = "暴は弊順�笋臨咾澄�\n弊順�笋�ら蛍叢され、繁�gたちと匯�wに伏試を僕り�Aけていた";
            }

        }
        if (countup >= 10.5f)
        {

            ritsuSelf.text = "けど、暴を夛るためには弊順�笋料Δ�樋まって\n��吭�Rが羽恠され、寄禍並になった";
        }
        if (countup > 15f && countup < 18f)
        {
            ritsuSelf.color = new Color32(255, 255, 255, 255);
            ritsuSelf.text = "書こそ、暴の叨朕を惚たせる�rだ";
            shijieshu1.SetActive(true);
            Destroy(white.gameObject);
        }
        if (countup > 18f)
        {
           
            ritsuSelf.text = "でも..この��徨を��ると、弊順�笋呂發�...\nじゃ、暴がすべてを簾�Г靴泙靴腓Γ�";
            shijieshu3.SetActive(true);
        }
        if (countup > 23f)
        {
           
            ritsuSelf.text = "仝お藤れ��です、弊順�笋気鵝�々\n仝書から暴が旗わりに徭隼を便るから...々";
            if (toumeido2 < 255f)
            {
                toumeido2 += 1f;
            }
            black.color = new Color32(0, 0, 0, (byte)toumeido2);
            if (toumeido2 >= 255f&& countup > 27f)
            {
         
                ritsuSelf.text = "仝もちろん、リットも匯�wにねぇ゛々";
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
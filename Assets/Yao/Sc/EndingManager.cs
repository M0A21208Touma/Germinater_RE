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
        //時間をカウントする
        countup += Time.deltaTime;

        Transform myTransform = ritsu.transform;
        Vector3 pos = myTransform.position;
        if (countup <= 3.3f)
        {
            pos.x += 0.01f;
            myTransform.position = pos;  // 座標を設定
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
            ritsuSelf.text = "「そうだ、思い出した。」";
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
                ritsuSelf.text = "私は世界樹の子　\n世界樹から分裂され、人間たちと一緒に生活を送り続けていた。";
            }

        }
        if (countup >= 11.5f)
        {

            ritsuSelf.text = "けれど、私を造るために世界樹の力が弱まって\n悪意識が暴走して、大惨事になった";
        }
        if (countup > 16f && countup < 19f)
        {
            ritsuSelf.color = new Color32(255, 255, 255, 255);
            ritsuSelf.text = "でも..この様子を見ると、世界樹はもう..";
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

            ritsuSelf.text = "今こそ、私の役目を果たす時　\nじゃ、私がすべてを吸収しましょう！";
            shijieshu3.SetActive(true);
        }
        if (countup > 24f)
        {

            ritsuSelf.text = "「お疲れ様です、世界樹さん。」\n「これから私が代わりに自然を守るから...」";
            if (toumeido2 < 255f)
            {
                toumeido2 += 1f;
            }
            black.color = new Color32(0, 0, 0, (byte)toumeido2);
            if (toumeido2 >= 255f && countup > 28f)
            {

                ritsuSelf.text = "「もちろん、リットも一緒にね」";
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelectManager : MonoBehaviour
{
    public Text stage1Text;
    public Text stage2Text;
    public Text stage3Text;
    [SerializeField] private float _cycle = 1;
    private double _time;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Stage1")
        {
            // �ڲ��r�̤�U�^������E
        _time += Time.deltaTime;
            // ����cycle���R��E�������ȡ�?
            // 0��cycle�ι��E�΂����ä餁E�E
            var alpha = Mathf.Cos((float)(2 * Mathf.PI * _time / _cycle)) * 0.5f + 0.5f;
            // �ڲ��r��time�ˤ�����E���״�B��ӳ
            // ���ץ饤��ɫ�Υ���Eե�����丁E��Ƥ���E
            var color = stage1Text.color;
            color.a = alpha;
            stage1Text.color = color;
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Stage1");//�����ǥ��`���w��!
                SceneManager.LoadScene("Kazusa_Demo");
            }
        }
        if (collision.gameObject.name == "Stage2")
        {
            // �ڲ��r�̤�U�^������E
            _time += Time.deltaTime;
            // ����cycle���R��E�������ȡ�?
            // 0��cycle�ι��E�΂����ä餁E�E
            var alpha = Mathf.Cos((float)(2 * Mathf.PI * _time / _cycle)) * 0.5f + 0.5f;
            // �ڲ��r��time�ˤ�����E���״�B��ӳ
            // ���ץ饤��ɫ�Υ���Eե�����丁E��Ƥ���E
            var color = stage2Text.color;
            color.a = alpha;
            stage2Text.color = color;
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Stage2");
                SceneManager.LoadScene("Stage2");
            }
        }
        if (collision.gameObject.name == "Stage3")
        {
            // �ڲ��r�̤�U�^������E
            _time += Time.deltaTime;
            // ����cycle���R��E�������ȡ�?
            // 0��cycle�ι��E�΂����ä餁E�E
            var alpha = Mathf.Cos((float)(2 * Mathf.PI * _time / _cycle)) * 0.5f + 0.5f;
            // �ڲ��r��time�ˤ�����E���״�B��ӳ
            // ���ץ饤��ɫ�Υ���Eե�����丁E��Ƥ���E
            var color = stage3Text.color;
            color.a = alpha;
            stage3Text.color = color;
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Stage3");
                SceneManager.LoadScene("Stage3");
            }
        }
    }
}

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
            // 内部時刻を経過させる
        _time += Time.deltaTime;
            // 周期cycleで繰り返す値の取得
            // 0～cycleの範囲の値が得られる
            var alpha = Mathf.Cos((float)(2 * Mathf.PI * _time / _cycle)) * 0.5f + 0.5f;
            // 内部時刻timeにおける明滅状態を反映
            // スプライト色のアルファ値を変更している
            var color = stage1Text.color;
            color.a = alpha;
            stage1Text.color = color;
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Stage1");//ここでシーン遷移!
                SceneManager.LoadScene("Kazusa_Demo");
            }
        }
        if (collision.gameObject.name == "Stage2")
        {
            // 内部時刻を経過させる
            _time += Time.deltaTime;
            // 周期cycleで繰り返す値の取得
            // 0～cycleの範囲の値が得られる
            var alpha = Mathf.Cos((float)(2 * Mathf.PI * _time / _cycle)) * 0.5f + 0.5f;
            // 内部時刻timeにおける明滅状態を反映
            // スプライト色のアルファ値を変更している
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
            // 内部時刻を経過させる
            _time += Time.deltaTime;
            // 周期cycleで繰り返す値の取得
            // 0～cycleの範囲の値が得られる
            var alpha = Mathf.Cos((float)(2 * Mathf.PI * _time / _cycle)) * 0.5f + 0.5f;
            // 内部時刻timeにおける明滅状態を反映
            // スプライト色のアルファ値を変更している
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

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
            // ﾄﾚｲｿ瓶ｿﾌ､Uﾟ^､ｵ､ｻ､・
        _time += Time.deltaTime;
            // ﾖﾜﾆﾚcycle､ﾇﾀR､・ｵ､ｹｎ､ﾎﾈ｡ｵ?
            // 0｡ｫcycle､ﾎｹ・､ﾎｎ､ｬｵﾃ､鬢・・
            var alpha = Mathf.Cos((float)(2 * Mathf.PI * _time / _cycle)) * 0.5f + 0.5f;
            // ﾄﾚｲｿ瓶ｿﾌtime､ﾋ､ｪ､ｱ､・釋ｴ腺､ｴﾓｳ
            // ･ｹ･ﾗ･鬣､･ﾈﾉｫ､ﾎ･｢･・ﾕ･｡ｎ､荳・ｷ､ﾆ､､､・
            var color = stage1Text.color;
            color.a = alpha;
            stage1Text.color = color;
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Stage1");//､ｳ､ｳ､ﾇ･ｷｩ`･wﾒﾆ!
                SceneManager.LoadScene("Kazusa_Demo");
            }
        }
        if (collision.gameObject.name == "Stage2")
        {
            // ﾄﾚｲｿ瓶ｿﾌ､Uﾟ^､ｵ､ｻ､・
            _time += Time.deltaTime;
            // ﾖﾜﾆﾚcycle､ﾇﾀR､・ｵ､ｹｎ､ﾎﾈ｡ｵ?
            // 0｡ｫcycle､ﾎｹ・､ﾎｎ､ｬｵﾃ､鬢・・
            var alpha = Mathf.Cos((float)(2 * Mathf.PI * _time / _cycle)) * 0.5f + 0.5f;
            // ﾄﾚｲｿ瓶ｿﾌtime､ﾋ､ｪ､ｱ､・釋ｴ腺､ｴﾓｳ
            // ･ｹ･ﾗ･鬣､･ﾈﾉｫ､ﾎ･｢･・ﾕ･｡ｎ､荳・ｷ､ﾆ､､､・
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
            // ﾄﾚｲｿ瓶ｿﾌ､Uﾟ^､ｵ､ｻ､・
            _time += Time.deltaTime;
            // ﾖﾜﾆﾚcycle､ﾇﾀR､・ｵ､ｹｎ､ﾎﾈ｡ｵ?
            // 0｡ｫcycle､ﾎｹ・､ﾎｎ､ｬｵﾃ､鬢・・
            var alpha = Mathf.Cos((float)(2 * Mathf.PI * _time / _cycle)) * 0.5f + 0.5f;
            // ﾄﾚｲｿ瓶ｿﾌtime､ﾋ､ｪ､ｱ､・釋ｴ腺､ｴﾓｳ
            // ･ｹ･ﾗ･鬣､･ﾈﾉｫ､ﾎ･｢･・ﾕ･｡ｎ､荳・ｷ､ﾆ､､､・
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

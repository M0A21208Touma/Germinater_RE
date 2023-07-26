using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningManager : MonoBehaviour
{
   public Sprite o1;
   public Sprite o2;
   public Sprite o3;
   public Sprite o4;
   public Sprite o5;
   public Sprite o6;
    public Text Openingtext;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }
    public void One()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o1;
        Openingtext.text = "はるか昔に、この世界は世界樹に守られてきた。";
    }  public void Two()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o2;
        Openingtext.text = "けど、急に世界樹の暴走により、森全体に毒霧が蔓延し、動物たちも混乱し始めた";
    } public void Three()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o3;
        Openingtext.text = "世界樹の僅かな善意識の指示により、精霊リットが作り出され";
    }
    public void Four()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o4;
        Openingtext.text = " 「リーツ」という少女がすべてを戻される力を持って、その子を世界樹へ導くことを任された";
    }
    public void Five()
    {
        GameObject.Find("opening").GetComponent<SpriteRenderer>().sprite = o5;
        Openingtext.text = "リットとリーツが出会い、世界樹の暴走をとめるため世界樹の中心へと向かうのであった。";
    }
 
    public void Skip()
    {
        SceneManager.LoadScene("StageSelect");
    }
    }


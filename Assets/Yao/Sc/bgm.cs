using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour
{
    //public bool DontDestroyEnabled = true;
    public AudioClip sound01;
    public AudioClip sound02;
    public AudioClip sound03;
    public AudioClip sound04;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        /*if (DontDestroyEnabled)
        {
            // Scene§Úﬂw“∆§∑§∆§‚•™•÷•∏•ß•Ø•»§¨œ˚§®§ §§§Ë§¶§À§π§ÅE
            DontDestroyOnLoad(this);
        }*/
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SearchErea.isEnemyS == true && SearchErea.SoundCount == 1)
        {
            SearchErea.isEnemyS = false;
            audioSource.PlayOneShot(sound01);
        }
        if (SearchErea.isFlowerS == true && SearchErea.SoundCount == 1)
        {
            SearchErea.isFlowerS = false;
            audioSource.PlayOneShot(sound02);
        }
        if(SpilitAction.isShoot == true)
        {
            audioSource.PlayOneShot(sound03);
            SpilitAction.isShoot = false;
        }
        if(WiindHit.isWind == true)
        {
            audioSource.PlayOneShot(sound04);
            WiindHit.isWind = false;
        }
    }
}
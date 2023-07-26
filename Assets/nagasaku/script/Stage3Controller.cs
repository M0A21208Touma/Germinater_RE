using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage3Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public void SwitchScene()
    {
        SceneManager.LoadScene("Stage3", LoadSceneMode.Single);
    }
}

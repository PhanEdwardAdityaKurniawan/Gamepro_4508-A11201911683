using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlay()
    {
        SceneManager.LoadScene ("Menu2");
    }
    public void OnCredits()
    {
        SceneManager.LoadScene ("CreditBG");
    }
    public void OnBack()
    {
        SceneManager.LoadScene ("Menu");
    }
    public void OnHelp()
    {
        SceneManager.LoadScene ("htp.unity");
    }
    public void OnLevel1()
    {
        SceneManager.LoadScene ("Main");
    }
    public void OnLevel2()
    {
        SceneManager.LoadScene ("Main3");
    }
    public void OnLevel3()
    {
        SceneManager.LoadScene ("Main4");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject LoginCanvas;
    public GameObject KakaoCanvas;
    public GameObject AccountCanvas;
    public GameObject FinishCanvas;
    // Start is called before the first frame update
    void Start()
    {
        LoginCanvas.SetActive(true);
        KakaoCanvas.SetActive(false);
        AccountCanvas.SetActive(false);
    }

    // Update is called once per frame
    public void Kakaobutton()
    {
        LoginCanvas.SetActive(false);
        KakaoCanvas.SetActive(true);
        AccountCanvas.SetActive(false);
    }

    public void Accountbutton()
    {
        LoginCanvas.SetActive(false);
        KakaoCanvas.SetActive(false);
        AccountCanvas.SetActive(true);
    }

    public void Joinbutton()
    {
        AccountCanvas.SetActive(false);
        FinishCanvas.SetActive(true);
    }

    public void Startbutton()
    {
        SceneManager.LoadScene(1);
    }

    public void Loginbutton()
    {
        SceneManager.LoadScene(1);
    }

}

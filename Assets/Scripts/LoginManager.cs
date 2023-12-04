using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    public GameObject LoginCanvas;
    public GameObject KakaoCanvas;
    public GameObject UnagreePanel;
    public GameObject AccountCanvas;
    public GameObject ServicePanel;
    public GameObject ServicePanel1;
    // Start is called before the first frame update
    void Start()
    {
        KakaoCanvas.SetActive(false);
        AccountCanvas.SetActive(false);
        ServicePanel1.SetActive(false);
    }

    public void OnClickKakaobutton()
    {
        LoginCanvas.SetActive(false);
        KakaoCanvas.SetActive(true);
        UnagreePanel.SetActive(true);
    }

    public void OnClickCancelbutton()
    {
        LoginCanvas.SetActive(true);
        KakaoCanvas.SetActive(false);  
    }

    public void OnClickAccountbutton()
    {
        LoginCanvas.SetActive(false);
        AccountCanvas.SetActive(true);
    }
    
    public void OnClickCheckbutoon()
    {
        ServicePanel.SetActive(false);
        ServicePanel1.SetActive(true);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    public GameObject LoginCanvas;
    public GameObject KakaoCanvas;
    public GameObject UnagreePanel;
    public GameObject AccountCanvas;
    public GameObject ServicePanel;     //acount
    public GameObject ServicePanel1;    //acount
    public GameObject OtherServicePanel;    //acount
    public GameObject OtherServicePanel1;   //acount
    // Start is called before the first frame update
    void Start()
    {
        KakaoCanvas.SetActive(false);
        AccountCanvas.SetActive(false);
        ServicePanel1.SetActive(false);
        OtherServicePanel1.SetActive(false);
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
    
    public void OnClickCheckbutton()
    {
        ServicePanel.SetActive(false);
        ServicePanel1.SetActive(true);
    }

    public void OnClickOtherCheckbutton()
    {
        OtherServicePanel.SetActive(false);
        OtherServicePanel1.SetActive(true);
    }


}

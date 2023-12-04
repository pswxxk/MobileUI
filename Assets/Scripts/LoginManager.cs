using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    public GameObject LoginCanvas;
    public GameObject KakaoCanvas;
    public GameObject UnagreePanel;
    // Start is called before the first frame update
    void Start()
    {
        KakaoCanvas.SetActive(false);       
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

}

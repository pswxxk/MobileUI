using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KakaoCanvas : MonoBehaviour
{
    public Toggle toggle;
    public GameObject UnagreePanel;
    public GameObject AgreePanel;

    public GameObject loginCanvas;
    public GameObject kakaoCanvas;

    // Start is called before the first frame update
    void Start()
    {
        toggle.isOn = false;
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
        UnagreePanel.SetActive(true);
        AgreePanel.SetActive(false);
    }

    void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {       
            UnagreePanel.SetActive(false);

            AgreePanel.SetActive(true);
        }
        else
        {
            AgreePanel.SetActive(false);

            UnagreePanel.SetActive(true);
        }
    }

    public void Cancelbutton()
    {
        loginCanvas.SetActive(true);
        kakaoCanvas.SetActive(false);
    }


}

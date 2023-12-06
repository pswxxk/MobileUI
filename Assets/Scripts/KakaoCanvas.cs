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
            // 현재 Canvas를 비활성화
            UnagreePanel.SetActive(false);

            // 다음 Canvas를 활성화
            AgreePanel.SetActive(true);
        }
        else
        {
            // Toggle이 꺼진 경우 다음 Canvas를 비활성화
            AgreePanel.SetActive(false);

            // 현재 Canvas를 활성화
            UnagreePanel.SetActive(true);
        }
    }

    public void Cancelbutton()
    {
        loginCanvas.SetActive(true);
        kakaoCanvas.SetActive(false);
    }


}

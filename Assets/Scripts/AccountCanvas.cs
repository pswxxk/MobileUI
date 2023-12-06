using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class AccountCanvas : MonoBehaviour
{
    public GameObject IndivisualPanel;
    public GameObject InterprisePanel;

    public Toggle Checktoggle;
    public Toggle Checktoggle1;

    public GameObject unagreePanel;
    public GameObject agreePanel;

    public GameObject unagreePanel1;
    public GameObject agreePanel1;
    // Start is called before the first frame update
    void Start()
    {
        //Checktoggle.isOn = false;
        //Checktoggle1.isOn = false;
        Checktoggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    // Update is called once per frame
    void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {
            unagreePanel.SetActive(false);

            agreePanel.SetActive(true);

            unagreePanel1.SetActive(false);

            agreePanel1.SetActive(true);
        }
        else
        {
            agreePanel.SetActive(false);

            unagreePanel.SetActive(true);

            agreePanel1.SetActive(false);

            unagreePanel1.SetActive(true) ;
        }
    }


}

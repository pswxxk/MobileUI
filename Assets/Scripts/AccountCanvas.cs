using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class AccountCanvas : MonoBehaviour
{
    public Toggle Indivisualtoggle;
    public Toggle Interprisetoggle;

    public Toggle CheckToggle;
    public Toggle CheckToggle1;

    public GameObject UnagreePanel;
    public GameObject AgreePanel;

    public GameObject UngreePanel1;
    public GameObject AgreePanel1;

    public GameObject IndivisualPanel;
    public GameObject InterprisePanel;

    public GameObject FinishButton;
    public GameObject FinishButton1;

    

    void Start()
    {
        Indivisualtoggle.isOn = true;
        Interprisetoggle.isOn = false;

        CheckToggle.isOn = false;
        CheckToggle1.isOn = false;

        UnagreePanel.SetActive(true);
        AgreePanel.SetActive(false);

        UngreePanel1.SetActive(true);
        AgreePanel1.SetActive(false);

        IndivisualPanel.SetActive(true);
        InterprisePanel.SetActive(false);


        Indivisualtoggle.onValueChanged.AddListener(delegate { OnIndivisualToggleValueChanged(); });
        Interprisetoggle.onValueChanged.AddListener(delegate { OnInterpriseToggleValueChanged(); });

        CheckToggle.onValueChanged.AddListener(delegate { OnCheckToggleValueChanged(); });
        CheckToggle1.onValueChanged.AddListener(delegate { OnCheckToggle1ValueChanged(); });
    }

    void OnIndivisualToggleValueChanged()
    {
        if (Indivisualtoggle.isOn)
        {
            Interprisetoggle.isOn = false; // InterprisetoggleÀ» ²û
            InterprisePanel.SetActive(false);
        }

        IndivisualPanel.SetActive(Indivisualtoggle.isOn);
    }

    void OnInterpriseToggleValueChanged()
    {
        if (Interprisetoggle.isOn)
        {
            Indivisualtoggle.isOn = false; // IndivisualtoggleÀ» ²û
            IndivisualPanel.SetActive(false);
        }

        InterprisePanel.SetActive(Interprisetoggle.isOn);
    }

    void OnCheckToggleValueChanged()
    {
        if (CheckToggle.isOn)
        {
            UnagreePanel.SetActive(false);
            AgreePanel.SetActive(true);
            FinishButton.SetActive(true);
        }
        else
        {
            UnagreePanel.SetActive(true);
            AgreePanel.SetActive(false);
            FinishButton.SetActive(false);
        }
    }

    void OnCheckToggle1ValueChanged()
    {
        if (CheckToggle1.isOn)
        {
            UngreePanel1.SetActive(false);
            AgreePanel1.SetActive(true);
            FinishButton1.SetActive(true);
        }
        else
        {
            UngreePanel1.SetActive(true);
            AgreePanel1.SetActive(false);
            FinishButton1.SetActive(false);
        }
    }




}

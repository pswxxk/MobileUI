using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    public Toggle NoneToggle;
    public Toggle Toggle1;
    public Toggle Toggle2;

    public GameObject Image1;
    public GameObject Image2;
    // Start is called before the first frame update
    void Start()
    {
        NoneToggle.isOn = true;

        NoneToggle.onValueChanged.AddListener(delegate { OnNoneToggleValueChanged(); });
        Toggle1.onValueChanged.AddListener(delegate { OnToggle1ValueChanged(); });
        Toggle2.onValueChanged.AddListener(delegate { OnToggle2ValueChanged(); });
    }

    void OnNoneToggleValueChanged()
    {
        if (NoneToggle.isOn)
        {
            Toggle1.isOn= false;
            Toggle2.isOn= false;

            Image1.SetActive(false);
            Image2.SetActive(false);
        }
    }

    void OnToggle1ValueChanged()
    {
        if (Toggle1.isOn)
        {
            NoneToggle.isOn= false;
            Toggle2.isOn= false;

            Image1.SetActive(true);
            Image2.SetActive(false);
        }
    }

    void OnToggle2ValueChanged()
    {
        if (Toggle2.isOn)
        {
            NoneToggle.isOn= false;
            Toggle1.isOn= false;

            Image1.SetActive(false);
            Image2.SetActive(true);
        }
    }
}
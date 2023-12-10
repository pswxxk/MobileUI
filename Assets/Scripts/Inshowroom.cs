using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inshowroom : MonoBehaviour
{
    public Toggle MenuToggle;
    public GameObject OptionPanel;
    // Start is called before the first frame update
    void Start()
    {
        MenuToggle.isOn = false;

        OptionPanel.SetActive(false);

        MenuToggle.onValueChanged.AddListener(delegate { OnMenuToggleValueChanged(); });
    }

    // Update is called once per frame
    void OnMenuToggleValueChanged()
    {
        if( MenuToggle.isOn) 
        { 
            OptionPanel.SetActive(true);
        }
        else
        {
            OptionPanel.SetActive(false);
        }

    }
}

using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject UnagreePanel; 
    public GameObject AgreePanel;   


    
    public Toggle toggle;
    public GameObject IndivisualPanel;
    public GameObject InterprisePanel;

    // Start is called before the first frame update
    void Start()
    {
        // Toggle 상태 변화를 감지하는 이벤트를 연결
        toggle.onValueChanged.AddListener(OnToggleValueChanged);


        UnagreePanel.SetActive(false);
    

        IndivisualPanel.SetActive(true);
        InterprisePanel.SetActive(false);
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

    public void OnclickIndivisualbutton()
    {
        InterprisePanel.SetActive(false);
        IndivisualPanel.SetActive(true);
    }

    public void OnclickInterprisebutton()
    {
        IndivisualPanel.SetActive(false);
        InterprisePanel.SetActive(true);
    }
}
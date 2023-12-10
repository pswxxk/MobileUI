using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowroomCanvas : MonoBehaviour
{
    public Canvas showroomCanvas;
    public Canvas InshowroomCanvas;

    public GameObject HomePanel;
    public GameObject MainPanel;
    public GameObject NoticePanel;
    public GameObject SearchPanel;
    public GameObject LikePanel;
    public GameObject MyPanel;
    public GameObject AvaterPanel;
    public GameObject StorePanel;

    public Toggle HomeToggle;
    public Toggle showroomToggle;
    public Toggle searchToggle;
    public Toggle likeToggle;
    public Toggle MyToggle;
    // Start is called before the first frame update
    void Start()
    {
        HomePanel.SetActive(true);
        HomeToggle.isOn = true;

        HomeToggle.onValueChanged.AddListener(delegate { OnHomeToggleValueChanged(); });
        showroomToggle.onValueChanged.AddListener(delegate { OnshowroomToggleValueChanged(); });
        searchToggle.onValueChanged.AddListener(delegate { OnsearchToggleValueChanged(); });
        likeToggle.onValueChanged.AddListener(delegate { OnlikeToggleValueChanged(); });
        MyToggle.onValueChanged.AddListener(delegate { OnMyToggleValueChanged(); });

    }

    void OnHomeToggleValueChanged()
    {
        if (HomeToggle.isOn)
        {
            showroomToggle.isOn = false;
            searchToggle.isOn = false;
            likeToggle.isOn = false;
            MyToggle.isOn = false;

            MainPanel.SetActive(false);
            SearchPanel.SetActive(false);
            LikePanel.SetActive(false);
            MyPanel.SetActive(false);
            AvaterPanel.SetActive(false);
            StorePanel.SetActive(false);
        }

        HomePanel.SetActive(HomeToggle.isOn);
    }

    void OnshowroomToggleValueChanged()
    {
        if ( showroomToggle.isOn)
        { 
            HomeToggle.isOn = false;
            searchToggle.isOn = false;
            likeToggle.isOn = false;
            MyToggle.isOn = false;

            HomePanel.SetActive(false);
            SearchPanel.SetActive(false);
            LikePanel.SetActive(false);
            MyPanel.SetActive(false);
            AvaterPanel.SetActive(false);
            StorePanel.SetActive(false);
        }

        MainPanel.SetActive(showroomToggle.isOn);
    }

    void OnsearchToggleValueChanged()
    {
        if (searchToggle.isOn)
        {
            HomeToggle.isOn = false;
            showroomToggle.isOn = false;
            likeToggle.isOn = false;
            MyToggle.isOn = false;

            HomePanel.SetActive(false);
            MainPanel.SetActive(false);
            LikePanel.SetActive(false);
            MyPanel.SetActive(false);
            AvaterPanel.SetActive(false);
            StorePanel.SetActive(false);
        }

        SearchPanel.SetActive(searchToggle.isOn);
    }

    void OnlikeToggleValueChanged()
    {
        if (likeToggle.isOn)
        {
            HomeToggle.isOn = false;
            showroomToggle.isOn = false;
            searchToggle.isOn = false;
            MyToggle.isOn = false;

            HomePanel.SetActive(false);
            MainPanel.SetActive(false);
            SearchPanel.SetActive(false);
            MyPanel.SetActive(false);
            AvaterPanel.SetActive(false);
            StorePanel.SetActive(false);
        }

        LikePanel.SetActive(likeToggle.isOn);
    }

    void OnMyToggleValueChanged()
    {
        if (MyToggle.isOn)
        {
            HomeToggle.isOn = false;
            showroomToggle.isOn = false;
            searchToggle.isOn = false;
            likeToggle.isOn = false;

            HomePanel.SetActive(false);
            MainPanel.SetActive(false);
            SearchPanel.SetActive(false);
            LikePanel.SetActive(false);
        }

        MyPanel.SetActive(MyToggle.isOn);
    }

    public void noticeButton()
    {
        HomePanel.SetActive(false);
        MainPanel.SetActive(false);
        NoticePanel.SetActive(true);
        SearchPanel.SetActive(false);
        LikePanel.SetActive(false);
        MyPanel.SetActive(false);
    }

    public void BackButton()
    {
        MainPanel.SetActive(true);
        NoticePanel.SetActive(false);
        SearchPanel.SetActive(false);
        LikePanel.SetActive(false);
        MyPanel.SetActive(false);
        HomePanel.SetActive(false);
    }

    public void showroomButton()
    {
        showroomCanvas.gameObject.SetActive(false);
        InshowroomCanvas.gameObject.SetActive(true);
    }

    public void SRBackButton()
    {
        showroomCanvas.gameObject.SetActive(true);
        InshowroomCanvas.gameObject.SetActive(false);   
    }

    public void HomeBackButton()
    {
        HomePanel.SetActive(true);
        AvaterPanel.SetActive(false);

    }

    public void CreateAvaterButton()
    {
        AvaterPanel.SetActive(true);
        HomePanel.SetActive(false);
    }

    public void StoreButton()
    {
        StorePanel.SetActive(true);
        HomePanel.SetActive(false);

    }




}

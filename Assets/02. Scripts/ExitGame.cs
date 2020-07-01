using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    public bool isOn;
    public Image image;

    public void On()
    {
        isOn = !isOn;
    }
    void Start()
    {
        isOn = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            On();
        }

        if (isOn)
            image.gameObject.SetActive(true);
        else
            image.gameObject.SetActive(false);
    }

    public void Onclick()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Payse : MonoBehaviour
{

    public GameObject panel;
    private bool payse;
    


    private void Start()
    {
        payse = false;
        Time.timeScale = 1;
        panel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!payse)
            {
                Payse_();
                
            }
            else
            {
                Resume();
            }
        }
        
    }

    public void Resume()
    {
        payse = false;
        Time.timeScale = 1;
        panel.SetActive(false);
    }

    void Payse_()
    {
        payse = true;
        Time.timeScale = 0;
        panel.SetActive(true);
    }

}

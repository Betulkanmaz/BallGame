using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DurdurmaMenu : MonoBehaviour
{
    public static bool Durdurma = false;
    public GameObject durdurmaPanel;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Durdurma)
            {
                Devam();
            }
            else
            {
                Durma();
            }
        }
    }

    public void Devam()
    {
        durdurmaPanel.SetActive(false);
        Time.timeScale = 1f;
        Durdurma = false;
    }

    public void AnaMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Yeniden()
    {
        SceneManager.LoadScene(1);
    }

    void Durma()
    {
        durdurmaPanel.SetActive(true);
        Time.timeScale = 0f;
        Durdurma = true;
    }
}

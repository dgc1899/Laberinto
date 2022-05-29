using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public static bool JuegoPausado = false;
    public GameObject pauseMenuUI;
    public GameObject btnP;

    void Update()
    {
        if (JuegoPausado == true)
        {
            if (JuegoPausado)
            {
                Pausa();
            }
            else
            {
                Resumen();
            }
        }
    }

    public void Resumen()
    {
        pauseMenuUI.SetActive(false);
        btnP.SetActive(true);
        Time.timeScale = 1f;
        JuegoPausado = false;
    }

    void Pausa()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        JuegoPausado = true;
    }

    public void CargarMenu()
    {
        Debug.Log("Menú...");
    }

    public void MuteMusic()
    {
        Debug.Log("Música...");
    }
}

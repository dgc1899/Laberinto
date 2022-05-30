using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public static bool JuegoPausado = false;
    public GameObject pauseMenuUI;
    public GameObject btnP;

    void Update()
    {
        if (JuegoPausado == true)
        {
            btnP.SetActive(false);
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
        JuegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuJugar");
        Debug.Log("Menú...");
    }

    public void Reiniciar()
    {
        JuegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel_1");
    }

    public void MuteMusic()
    {
        if (AudioListener.volume > 0)
        {
            AudioListener.volume = 0;
        }
        else if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1f;
        }
    }
}

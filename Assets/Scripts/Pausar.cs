using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausar : MonoBehaviour
{
  public GameObject btnP;

  public void Pause()
  {
        MenuPausa.JuegoPausado = true;
        Debug.Log("Pausa");
  }
}

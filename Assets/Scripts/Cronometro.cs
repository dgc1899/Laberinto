using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public Text UItexto;
    public int contador = 0;


    private void Awake()
    {
        InvokeRepeating("Timer", 0f, 1f);
    }

    public void Timer()
    {
        contador++;
        UItexto.text = contador.ToString();
    }
}

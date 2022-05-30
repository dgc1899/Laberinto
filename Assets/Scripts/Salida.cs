using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salida : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Juego.setYouWinToTrue();
    }
}

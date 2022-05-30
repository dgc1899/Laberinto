using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Juego.setIsDeadTrue();
    }
}

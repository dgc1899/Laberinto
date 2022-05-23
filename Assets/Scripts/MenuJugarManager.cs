using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJugarManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Regresar a Menu principal
    public void EscenaMenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    }
}

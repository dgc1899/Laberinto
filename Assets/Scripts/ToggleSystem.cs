using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;


public class ToggleSystem : MonoBehaviour
{
    ToggleGroup toggleGroup;
    // Start is called before the first frame update
    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Submit()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        if (toggle.name == "ToggleNivel1")
        {
            SceneManager.LoadScene("Nivel_1");
        }
        if (toggle.name == "ToggleNivel2")
        {
            SceneManager.LoadScene("Nivel_2");
        }
        if (toggle.name == "ToggleNivel3")
        {
            SceneManager.LoadScene("Nivel_3");
        }

    }
}

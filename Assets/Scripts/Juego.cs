using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Juego : MonoBehaviour
{
    private Rigidbody rb;
    private float velocidad = 20f;

    static bool isDead;
    static bool move;
    static bool youWin;

    [SerializeField]
    GameObject TextoGanador;

    public GameObject FinUI;

    public Text Tiempo;
    public Text Ganar;

    //public Text titulo;
    //public Text segundos;

    public int contador = 0;
    public int contador2 = 0;
    

    private void Awake()
    {
        InvokeRepeating("Timer", 0f, 1f);
    }

    public void Timer()
    {
        contador++;
        Tiempo.text = contador.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        TextoGanador.gameObject.SetActive(false);

        rb = GetComponent<Rigidbody>();

        youWin = false;
        move = true;
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (isDead == true)
        {
            rb.position = new Vector3(-8.5f, 1f, 7.96f);
            isDead = false;

            contador2++;
            if (contador2 == 3)
            {
                move = false;
                SceneManager.LoadScene("MenuJugar");
                Debug.Log("Se te acabaron la vidas");
            }
        }

        if(youWin == true)
        {
            //TextoGanador.gameObject.SetActive(true);
            FinUI.gameObject.SetActive(true);
            //titulo.text = "Final del juego";
            //segundos.text = contador.ToString() + " segundos";
            move = false;
            //Invoke("RestartScene", 2f);
            CancelInvoke("Timer");

            if (contador <= 15)
            {
                Debug.Log("3 estrellas");
            }
            else if(contador <= 20)
            {
                Debug.Log("2 estrellas");
            }
            else
            {
                Debug.Log("1 estrella");
            }
            //Ganar.text = "Felicidades, terminaste con un tiempo de: " + contador.ToString() + " seg";
        }
    }

    void FixedUpdate()
    {
        if (move == true)
        { 
            Vector3 tilt = Input.acceleration;
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
            rb.AddForce(tilt * velocidad);
        }
    }

    public static void setIsDeadTrue()
    {
        isDead = true;
    }

    public static void setYouWinToTrue()
    {
        youWin = true;
    }

    void RestartScene()
    {
        SceneManager.LoadScene("Nivel_1");
    }
}

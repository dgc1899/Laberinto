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
    public GameObject btnP;

    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject TV1;
    public GameObject TV2;
    public GameObject TV3;
    public GameObject C1;
    public GameObject C2;
    public GameObject C3;

    public GameObject FinUI;

    public Text Tiempo;
    public Text Ganar;

    public Text G_P;
    public Text segundos;

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

            if (contador2 == 1)
            {
                C3.gameObject.SetActive(false);
            }
            else if(contador2 == 2)
            {
                C2.gameObject.SetActive(false);
            }
            else if (contador2 == 3)
            {
                C3.gameObject.SetActive(false);

                T1.gameObject.SetActive(false);
                T2.gameObject.SetActive(false);
                T3.gameObject.SetActive(false);

                TV1.gameObject.SetActive(true);
                TV2.gameObject.SetActive(true);
                TV3.gameObject.SetActive(true);

                move = false;
                FinUI.gameObject.SetActive(true);
                CancelInvoke("Timer");
                G_P.text = "Mejor suerte para la próxima";
                btnP.SetActive(false);
                Tiempo.text = "";
                segundos.text = contador.ToString() + " segundos";
                Invoke("RegresarMenu", 3f);
            }
        }

        if(youWin == true)
        {
            FinUI.gameObject.SetActive(true);
            G_P.text = "Terminaste el nivel, felicidades";
            segundos.text = contador.ToString() + " segundos";
            move = false;
            btnP.SetActive(false);
            Tiempo.text = "";
            Invoke("RegresarMenu", 3f);
            CancelInvoke("Timer");

            if (contador <= 15)
            {
                T1.gameObject.SetActive(true);
                T2.gameObject.SetActive(true);
                T3.gameObject.SetActive(true);

                TV1.gameObject.SetActive(false);
                TV2.gameObject.SetActive(false);
                TV3.gameObject.SetActive(false);

            }
            else if(contador <= 20)
            {
                TV1.gameObject.SetActive(true);
                TV2.gameObject.SetActive(true);
                TV3.gameObject.SetActive(false);

                TV1.gameObject.SetActive(false);
                TV2.gameObject.SetActive(false);
                TV3.gameObject.SetActive(true);
            }
            else
            {
                T1.gameObject.SetActive(true);
                T2.gameObject.SetActive(false);
                T3.gameObject.SetActive(false);

                TV1.gameObject.SetActive(false);
                TV2.gameObject.SetActive(true);
                TV3.gameObject.SetActive(true);

            }
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

    void RegresarMenu()
    {
        SceneManager.LoadScene("MenuJugar");
    }
}

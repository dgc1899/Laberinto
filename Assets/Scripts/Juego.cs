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

    public Text Tiempo;
    public Text Ganar;
    public int contador = 0;

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
        }

        if(youWin == true)
        {
            TextoGanador.gameObject.SetActive(true);
            move = false;
            Invoke("RestartScene", 2f);
            CancelInvoke("Timer");
            Ganar.text = "Felicidades, terminaste con un tiempo de: " + contador.ToString() + " seg";
            Debug.Log(contador);
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

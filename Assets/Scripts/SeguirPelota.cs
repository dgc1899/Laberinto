using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPelota : MonoBehaviour
{
    public GameObject Pelota;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Pelota.transform.position + new Vector3(0,25f,0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contador : MonoBehaviour
{
    public float tiempo;
    public float tiempoEspera = 0;
    public bool esperando;

    public int frames;

    // Start is called before the first frame update
    void Start()
    {
        tiempo = 100;
        esperando = true;
    }

    // Update is called once per frame
    void Update()
    {
        frames = frames + 1;
        tiempo = tiempo - Time.deltaTime;
        if (tiempo < tiempoEspera){
            esperando = !esperando;
            tiempo = 0;
        }
    }
}

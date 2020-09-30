using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCamara : MonoBehaviour
{
    public Transform personaje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(personaje.transform.position.x , personaje.transform.position.y , gameObject.transform.position.z);
    }
}

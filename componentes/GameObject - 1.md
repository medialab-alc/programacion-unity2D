El GameObject es la clase base para cualquier objeto dentro de una escena en Unity.

# Variables

Nombre | Tipo | Dato
------------|------------|------------
activeInHierarchy | bool | Define si el gameObject está activo o no en la escena
activeSelf | bool | El estado activo local de este GameObject
layer | int | El valor de índice de la capa en la que se encuentra el gameObject
tag	| string | El tag de este game object
transform | Transform |	El Transform adjuntado a este GameObject

# Constructores
GameObject | Crea un nuevo game object con un nombre asignado
Ej:
```C#
//// Se crea un nuevo GameObject y se le asigna un Rigidbody y un BoxCollider (ver más adelante AddComponent)
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    void Start()
    {
        GameObject player;
        player = new GameObject("Player");
        player.AddComponent<Rigidbody2D>();
        player.AddComponent<BoxCollider2D>();
    }
}
```

# Funciones Públicas
Nombre | Función
-----------|-----------
AddComponent<Type componentType>() | Agrega una clase componente de un tipo dado al GameObject. Ej: ```AddComponent<BoxCollider2D>();```
BroadcastMessage	Llama al método denominado methodName de todos los MonoBehaviour en este game objecto en cualquiera de sus hijos.
CompareTag	¿Este game object está etiquetado con tag?
GetComponent	Devuelve un componente de tipo type si el game object tiene a alguno adjuntado, o null si no lo tiene.
GetComponentInChildren	Devuelve el componente del tipo type en el GameObject o en alguno de sus hijos usando búsqueda de primero en profundidad.
GetComponentInParent	Retorna el componente de tipo type en el GameObject o cualquiera de sus padres.
GetComponents	Devuelve todos los componentes del tipo type en el GameObject.
GetComponentsInChildren	Devuelve todos los componentes del tipo type en el GameObject, o alguno de sus hijos.
GetComponentsInParent	Devuelve todos los componentes del tipo type en el GameObject o en alguno de sus padres.
SendMessage	Llama al método denominado methodName en cada MonoBehaviour de este game object.
SendMessageUpwards	Llama al método denominado methodName en todos los MonoBehaviour de este juego y en todos los ancestros del behaviour.
SetActive	Activa/Desactiva el GameObject.

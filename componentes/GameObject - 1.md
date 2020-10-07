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
-----------|-----------
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
AddComponent<*Tipo de componente*>() | Agrega una clase componente de un tipo dado al GameObject. Ej: ```AddComponent<BoxCollider2D>();```
BroadcastMessage(*Nombre de la función*, *Valor opcional a pasar a la función indicada*) | Llama la función con el nombre específicado en todos los MonoBehaviour en este objeto y en cualquiera de sus hijos (Esta función la veremos en profundidad más adelante)
CompareTag(String) | La función devuelve un booleano, el estado es "true" si el Tag del GameObject bajo el cual se llama la función posee el tag dado al llamar la función, el estado que devuelve es "false" en caso contrario.
GetComponent<*Tipo de componente*>() | Devuelve un componente del tipo indicado si el GameObject posee alguno adjuntado, o null si no lo tiene.
GetComponentInChildren<*Tipo de componente*>() | Devuelve el componente del tipo indicado en el GameObject o en alguno de sus hijos.
GetComponentInParent<*Tipo de componente*>() | Devuelve el componente del tipo indicado en el GameObject o cualquiera de sus padres.
SendMessage(*Nombre de la función*, *Valor opcional a pasar a la función indicada*) | Llama la función con el nombre especificado en cada MonoBehaviour de este objeto.
SendMessageUpwards(*Nombre de la función*, *Valor opcional a pasar a la función indicada*) | Llama la función con el nombre especificado en todos los MonoBehaviour de este juego.
SetActive(bool) | Activa/Desactiva el GameObject.

# Funciones Estáticas
Nombre | Función
-----------|-----------
!Find(String) | Devuelve un GameObject con el nombre indicado
FindGameObjectsWithTag(string) | Devuelve una lista de GameObjects activos etiquetados con el tag indicado. Devuelve un array vacío si ningún GameObject fue encontrado.
FindWithTag | Devuelve un GameObject activo etiquetado con el tag indicado. Devuelve null si ningún GameObject fue encontrado.



## Miembros Heredados

# Funciones Estáticas
Nombre | Función
-----------|-----------
Destroy(*Objeto*,float) | Elimina un gameobject, componente o asset. Se debe indicar el objeto y el tiempo luego del cual el mismo será destruido.
DontDestroyOnLoad(*Objeto*) | Hace que el GameObject indicado no sea destruído al cargar una nueva escena.
FindObjectOfType(*Tipo de objeto*) | Devuelve el primer objeto activo cargado del tipo indicado.
FindObjectsOfType(*Tipo de objeto*) | Devuelve una lista de todos los objetos activos cargados del tipo indicado.
Instantiate(*Objeto original*, Vector3, Quaternion, Transform) | Clona el objeto original y devuelve el clon, al mismo se le puede indicar la posición en la cual debe crearse el clon (Vector3), los valores de rotación (Quaternion) y el transform padre (Transform), estos inputs son opcionales, la función puede llamarse solamente con el objeto a clonar.


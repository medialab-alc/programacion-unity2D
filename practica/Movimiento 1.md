### Repaso de elementos a utilizar en la práctica:

Si una variable se declara con "public" al inicio (ej: public int edad;) la misma aparecerá en el inspector al seleccionar el objeto en el que esté colocado el script y el valor inicial de la variable podrá definirse desde allí.

**TIPOS DE VARIABLES**
- **int**: Números enteros.
- **float**: Números con coma flotante.
- **bool**: verdadero o falso, la variable se debe inicializar con "true" o "false".
- **Vector2**: Vector de dos coordenadas 
*Recordar que este tipo de variable se inicializa de la siguiente manera*
```C#
Vector2 velocidad = new Vector2(0,1);
```

**FUNCIONES**
- **void Start(){}** : La función start se ejecuta una sola vez al iniciarse el juego, se utiliza por ejemplo para definir los valores que queremos que tengan las variables al comenzar el juego (por ejemplo, vida inicial, posición inicial, etc.)
- **void Update(){}** : Se ejecuta una vez por cada frame, permitiendo generar loops y modificar determinadas variables para generar comportamientos cíclicos y variantes a lo largo del programa en función de dichas variables.

OPCIONAL: **void FixedUpdate(){}** : La función "Update" se ejecuta una vez por frame, la cantidad de frames por segundo depende de la velocidad del ordenador y la memoria disponible. La función FixedUpdate en cambio se ejecuta siempre en los mismos intervalos de tiempo (50 veces por segundo por defecto).

**COMPONENTES**
Vamos a trabajar con el componente [Transform](https://github.com/medialab-alc/programacion-unity2D/blob/master/componentes/Transform%20-%201.md), el cual determina la posición, rotación y escala del objeto en el espacio virtual.

Particularmente vamos a estar accediendo a la variable "position", de tipo Vector3.
Para acceder a la variable position del objeto en el cual esté colocado el script debemos hacerlo de la siguiente manera:
```C#
gameObject.tranform.position
///////////// A su vez podemos también acceder al componente X y al componente Y del vector position por separado
gameObject.tranform.position.x
gameObject.tranform.position.y
```
Primero debemos indicar a qué objeto estamos accediendo (al poner *gameObject* refiere al objeto en el que esté colocado el script), luego a qué componente de ese objeto (transform), y finalmente a qué variable de ese componente (position). Cada nivel al que accedemos en esa jerarquía se debe separar por un punto.

### Práctica de manipulación básica del componente transform

- En una nueva escena llamada "Practica 1", crear un objeto de tipo Sprite (Click derecho en la pestaña Hierarchy => 2D Object => Sprite) y asignarle una imagen simple de referencia.
- En caso de no contar con ella, crear una nueva carpeta en la pestaña de Proyecto dentro de la carpeta Assets que se llame "Scripts"
- Crear un nuevo script de C# llamado "PracticaMovimiento1" (Click derecho en la pestaña Project => Create => C# Script)
- Asignar el Script al Sprite creado.
- Abrir el script en Visual Studio Code


Siguiendo lo visto en clase, se deberá utilizar las funciones *void Start()* y *void Update()* y acceder al componente transform para generar en el sprite colocado los siguientes tipos de movimiento:

  **1:** Que el objeto se mueva de manera constante en una dirección cualquiera.
  
  **2:** Que al llegar a un punto dado por algunas coordenadas X e Y a elección, se invierta el sentido del movimiento ("Si la posición actual es menor a la posición deseada moverse hacia adelante, si no...")
  
  **3:** Que al volver al punto inicial, el objeto vuelva a invertir la dirección de movimiento.
  




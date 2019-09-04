# Introducción
Unity maneja un sistema de objetos en el cual cada uno de los denominados "GameObjects" funciona como un contenedor de para una serie de componentes que pueden ser atados al mismo para modificar y controlar su comportamiento o sus propiedades.
Si bien dichos componentes pueden ser configurados directamente desde el Inspector de manera gráfica, el uso de scripts nos permite (entre otras cosas) ingresar a dichos componentes y modificar sus valores de manera dinámica, de manera de crear comportamientos más complejos e interactivos para cada uno de estos objetos.

En esta primera introducción veremos los componentes básicos que necesitamos conocer para trabajar con scripts en C# en Unity, utilizando como base los scripts que estuvimos creando para las plataformas.

### VIARIABLES
Las variables almacenan un tipo de información, el tipo de información depende del tipo de variable.
Un tipo de metáfora que se utiliza para comprender mejor las variables es la de imaginarlas como cajas, cada variable es una caja que contiene un tipo de información, y cada tipo de información requiere un tipo de caja distinta.

**Algunos tipos de variables:**
int: Almacena un número entero
float: Almacena un número decimal
bool: Almacena un dato del tipo "verdadero" o "falso"
char: Almacena un caracter
string: Almacena una serie de caracteres

Las variables siempre deben ser declaradas con un nombre, cada nombre debe ser único para cada variable y siempre es recomendable utilizar una sintaxis simple y relacionada a la función u objetivo de la variable.
**Ej:**
```C#
int velX;
bool acelerar;
string nombre;
```

Las variables a su vez deben eventualmente ser inicializadas, es decir se les debe asignar un dato del tipo de la variable.
Esto puede hacerse directamente cuando la variable es declarada, como en otra parte de nuestro código.
**Ej:**
```C#
int velX = 5;
bool acelerar = true;
string nombre = "Carlos"
```
```C#
int velX;
bool acelerar;
string nombre"

void Start(){
  velX = 5;
  acelerar = true;
  nombre = "Carlos";
}
```
**Recordar que siempre y como en la mayoría de los casos en que declaremos o modifiquemos valores en variables, la línea debe terminar de declararse con un punto y coma ;**

### FUNCIONES
Las funciones ejecutan una tarea específica para la cual son programadas
Unity posee funciones predeterminadas que siguen determinadas reglas más allá de la programación que se coloque dentro, pero también es posible crear nuestras propias funciones desde cero.
Las funciones también tienen un tipo de variable asociado, el cual define el tipo de variable que devuelven.

Siguiendo con la metáfora anterior, si las variables funcionan como cajas que contienen información, las funciones actúan como máquinas, las cuales vamos a alimentar con una o más de estas cajas y luego de procesarlas nos van a devolver un resultado.

Las funciones declaradas con el tipo "void" no devuelven ningún valor.
Luego de declarar una nueva función, el contenido de la función debe estar siempre contenido en llaves "{}".

Algunos ejemplos de funciones:
```C#
void Start(){
}
```
La función Start() se ejecuta en el primer frame en que el script es activado, antes de que ningún void Update() corra por primera vez. Se utiliza generalmente para declarar variables y definir todo aquello que queremos que esté seteado desde el comienzo.
Esta función se ejecuta una sola vez.

```C#
void Update(){
}
```
La función Update() es llamada en cada frame mientras el script esté activado, generando un loop constante y permitiendo que la función se retroalimente a si misma, en el caso en que dentro de ella se procesen variables o se llamen otras funciones que luego vaya a reutilizar.
Por ejemplo si tenemos un ```int contador = 0;``` y nuestra función update es la siguiente:
```C#
void Update(){
contador = contador + 1;
}
```
En el primer frame en que la función Update sea llamada contador será igual a 0, al ejecutar la función se le sumará 1. 
En el siguiente frame contador ahora tendrá un valor de 1, y se le volverá a sumar 1, y así de manera progresiva.

```C#
void FixedUpdate(){
}
```
A diferencia de Update(), la función FixedUpdate() es un loop independiente de los Frames, dependiendo de ciertos factores como la velocidad del procesador el Frame rate (la frecuencia con la que cada frame es llamado en pantalla) puede variar y con ello el tiempo entre cada una de las veces que la función Update() es llamada. FixedUpdate() es llamado siempre en intervalos fijos (la configuración predeterminada es 0.02s o lo que es lo mismo 50 veces por segundo).

### CLASES
Las clases funcionan como contenedores para funciones y variables, nuevamente con la misma metáfora anterior, podríamos decir que las clases son las fábricas en las cuales agrupamos las máquinas y cajas dependiendo de su función específica o de los distintos usos que querramos darles.
En Unity cada script contiene una clase específica con la cual define el contenido del mismo. 
Al crear un nuevo C# Script nos encontraremos siempre con algo como esto en la parte superior:

```C#
public class NombreDelScript : MonoBehaviour
```
**El nombre de la clase siempre debe ser el mismo que el nombre del script, por lo que al modificar uno hay que recordar siempre modificar el otro**

Al igual que en las funciones, el contenido de una clase siempre debe estar delimitado con llaves "{}" por lo que la manera correcta de declarar una clase siempre debe ser:
```C#
public class NombreDelScript : MonoBehaviour
{
/// CONTENIDO
}
```
La clase "MonoBehaviour" es la clase básica de la cual derivan todos los scripts en Unity, esta clase ya viene con ciertas funciones y métodos preconfigurados como las que vimos anteriormente (Update(), Start(), FixedUpdate(), etc)

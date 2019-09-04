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

### FUNCIONES
Las funciones ejecutan una tarea específica para la cual son programadas
Unity posee funciones predeterminadas que siguen determinadas reglas más allá de la programación que se coloque dentro, pero también es posible crear nuestras propias funciones desde cero.
Las funciones también tienen un tipo de variable asociado, el cual define el tipo de variable que devuelven.

Siguiendo con la metáfora anterior, si las variables funcionan como cajas que contienen información, las funciones actúan como máquinas, las cuales vamos a alimentar con una o más de estas cajas y luego de procesarlas nos van a devolver un resultado.

Las funciones declaradas con el tipo "void" no devuelven ningún valor.

### CLASES
Las clases funcionan como contenedores para funciones y variables, nuevamente con la misma metáfora anterior, podríamos decir que las clases son las fábricas en las cuales agrupamos las máquinas y cajas dependiendo de su función específica o de los distintos usos que querramos darles.
En Unity cada script contiene una clase específica con la cual define el contenido del mismo. 
Al crear un nuevo C# Script nos encontraremos siempre con algo como esto en la parte superior:

```
public class plataformaHorizontal: MonoBehaviour
```

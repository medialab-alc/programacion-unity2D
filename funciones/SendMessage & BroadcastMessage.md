SendMessage

La función SendMessage se utiliza para ejecutar una función que se encuentre en algún script de un GameObject en específico. 

Se debe indicar el nombre de la función deseada, y en caso de que alguno de los scripts asociados al objeto contenga una función con el mismo nombre, la misma se ejecutará. En el caso de que la función requiera algún parámetro o variable, este también se puede indicar dentro de la función SendMessage.

Este es el sistema que utiliza Unity en la detección de colisiones.
Por ejemplo, cuando un collider entra en contacto con otro, el sistema de colisiones envía el mensaje “OnCollisionEnter” a cada uno de los objetos involucrados en la colisión. Si alguno de esos objetos tiene un script asociado en el que esté declarada una función del mismo nombre, entonces dicha función se ejecuta.

Ejemplos de uso:
GameObject.SendMessage(Nombre de la función);
GameObject.SendMessage(Nombre de la función, parámetro);

GameObject: La función SendMessage manda un mensaje a un Objeto en específico. 
Si ya contamos con una referencia a un GameObject en nuestro script, entonces podemos colocar el nombre que le asignamos a dicha referencia.

Ej:
























Nombre de la función: El nombre de la función que queremos llamar, debe corresponder exactamente con el nombre de la función que se encuentre en algún script del objeto indicado.


Script ubicado en el objeto de origen
Script ubicado en el GameObject referenciado en el script de la izquierda



Parámetro: En el caso de que la función lo requiera, podemos llamar la función indicada dándole un parámetro específico.
El o los parámetros es uno o más datos/variables con los cuales alimentaremos la función o que serán utilizados dentro de la misma. Al crear una función que utilice algún parámetro, debe indicarse primero el tipo de variable o referencia y luego el nombre dado a la misma.

Usando un ejemplo similar al de arriba:
Script ubicado en el objeto de origen
Script ubicado en el GameObject referenciado en el script de la izquierda


*En la imagen de la izquierda se envía un mensaje para ejecutar la función “Prueba” y a dicha función se le pasa un valor entero (también se puede pasar una variable o una referencia)

*En la imagen de la derecha, a la función “Prueba” se le indica que para ejecutarse necesita recibir un dato de tipo Int, por lo que se declara la variable y se le da el nombre “x”.
La variable “x” almacenará el parámetro recibido cuando se llame esa función.


NOTA: Una función que se declare con algún parámetro (como en el caso de la imagen de la derecha) no puede 

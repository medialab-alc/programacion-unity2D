El componente transform determina la posición, rotación y escala de un objeto dentro de la escena. 
Todo gameObject cuenta con un componente dle tipo Transform.

# Propiedades

**Position:** 	Posición del Transform en coordenadas X, Y, Z.  
**Rotation:** 	Rotación del Transform alrededor de los ejes X, Y, Z, medido en grados.  
**Scale:** 	Scale (Escala) del Transform a lo largo de los ejes X, Y y Z. Un valor de “1” es el tamaño original (el tamaño con el cual el objeto fue importado).  


# CLASE
Todo objeto en la escena posee un transform, y a su vez cada transform permite tener un objeto padre, por lo que las propiedades de posición, rotación y escala pueden de esta manera ser jerárquicas y en relación al transform padre.

La clase transform viene ya con una serie de variables y funciones públicas predeterminadas, en esta primera instancia listaremos solo aquellas que vamos a utilizar con mayor frecuencia:

### Variables
Variable | Función
------------ | -------------
forward | Es un vector que representa el eje azul del transform en la escena, indica la dirección que el objeto considera "hacia adelante"
localPosition | Es un vector dado por los valores de posición del transform **relativo al transform padre**
localRotation | Valores de rotación **relativos al transform padre**, las rotaciones son expresadas con un [quaternion](https://docs.unity3d.com/es/current/ScriptReference/Quaternion.html)
parent | El padre del transform
position | El vector que representa la posición del transform en el mundo
rotation | El quaternion que define la rotación de los ejes del transform con respecto al mundo
up | Representa el eje verde del transform

### Funciones Públicas
Variable | Función
------------ | -------------
GetChild | Devuelve un transform hijo según el índice que ingresemos al llamar la función
IsChildOf | Devuelve un booleano que será verdadero o falso dependiendo si el transform actual es hijo del transform dado
LookAt | Gira el transform para que el vector **forward** apunte en la dirección del transform dado al llamar la función.
rotate | Aplica una rotación en grados sobre los ejes del objeto.
SetParent | Configura el padre del transform actual.
Translate | Mueve el transform en la dirección y distancia dada por el vector dado.

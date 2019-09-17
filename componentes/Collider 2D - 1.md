El collider 2D define la forma de un objeto 2D en relación al sistema de detección de colisiones físicas. Los collider son invisibles y no es necesario que su tamaño sea el mismo que el del sprite del objeto en el que están colocados.

En general la forma del collider dependerá de la función que se le quiera dar y de la superficie de colisión que se quiera que el objeto tenga, dentro del juego no es necesario que un collider tenga exactamente la misma figura del objeto cuyos límites representa, generalmente es más eficiente definir una forma básica aproximada a la forma del objeto, lo cual es generalmente indistinguible dentro de la experiencia del juego.

Los colliders para objetos 2D todos deben terminar con "2D", un collider que no lo aclare está pensado para su utilización en objetos 3D. No se pueden mezclar un Collider 2D con un objeto 3D o viceversa.

## Tipos de Collider2D:
Tipo | Descripción
------------ | -------------
Circle Collider 2D | Para áreas de colisión circulares con un radio dado.
Box Collider 2D | Un collider rectangular con alto y ancho dados, los ejes están siempre en función a los ejes locales del sprite2D al que esté ligado
Polygon Collider 2D | Un collider de forma libre hecho con segmentos de línea que se pueden ajustar de manera más libre, el resultado debe ser siempre una forma cerrada
Edge Collider 2D | A diferencia del Polygon Collider2D, el Edge collider no requiere de ser una forma cerrada, es un collider también conformado por segmentos de línea, pero su forma final puede ser una L o una línea.
Capsule Collider 2D | Collider con forma de cápsula, los bordes redondeados hacen más difícil que el collider pueda atascarse con otros colisionadores.
Composite Collider 2D | Une todas las formas de los Polygon Collider2D o Box Collider2D (a los que que se les indique la opción "Used by composite") dentro del objeto indicado en una única forma controlada por el Composite Collider.

# Propiedades
Propiedad | Función
------------ | -------------
Material | Un Physics Material que determina las propiedades de las colisiones, tales como la fricción y el rebote.
Is Trigger | Determina si el collider se comporta como Trigger
Used by Effector | Define si el collider es utilizado por un effector adjunto.
Offset | La variación local de la geometría del collider.
Radius | [Circle Collider] Radio del círculo en unidades del espacio local.

# Variables
[...]

# Funciones
[...]

# Ejemplo
[...]

El componente Rigidbody coloca al objeto bajo el control del motor de físicas de Unity

# Componentes
### Body Type:
El componente Rigidbody 2D tiene una configuración en la parte superior etiquetada como Body Type. La opción que elija para esto afecta otras configuraciones disponibles en el componente y particularmente definirá tanto el comportamiento de movimiento del objeto, como su interacción con los collider.

-**Dynamic**: Un Dynamic Rigidbody 2D está diseñado para moverse bajo simulación. Tiene todo el conjunto de propiedades disponibles, con una masa finita y un valor de arrastre/rozamiento, y se ve afectado por la gravedad y las fuerzas. 
Un cuerpo dinámico permite colisiones con cualquier otro tipo de cuerpo y es el más interactivo. 
Dynamic es la opción predeterminada para un Rigidbody 2D, porque es el tipo de cuerpo más común para los objetos que necesitan moverse. Todas las propiedades un Rididbody2D están disponibles con este tipo de cuerpo.
No se debe utilizar el componente Transform para establecer la posición o la rotación de un Dynamic Rigidbody 2D. La simulación vuelve a reubicar el Dynamic Rigidbody 2D de acuerdo con su velocidad; puede cambiar esto directamente a través de fuerzas aplicadas por scripts, o indirectamente a través de colisiones y gravedad.

-**Kinematic**: Un Kinematic Rigidbody 2D está diseñado para moverse bajo simulación pero solo bajo un control definido por parte del usuario. A diferencia de un Dynamic Rigidbody 2D, este no se ve afectado por las fuerzas y la gravedad. 
Los Rigidbody 2D Kinematic están diseñados para ser reubicados explícitamente a través de Rigidbody2D.MovePosition o Rigidbody2D.MoveRotation. Se utilizan consultas de física para detectar colisiones y scripts para decidir dónde y cómo se moverá el Rigidbody 2D.
Un Rigidbody 2D Kinematic todavía se mueve a través de su velocidad, pero la velocidad no se ve afectada por las fuerzas o la gravedad. Un Rigidbody 2D Kinematic no colisiona con otros Rigidbody 2D Kinematic o con Rigidbody 2Ds Static; solo colisiona con los Rigidbody 2D Dynamic. Durante las colisiones, un Kinematic Rigidbody se comporta como un objeto inamovible (como si tuviera masa infinita), las propiedades de masa no están disponible para este tipo de Rigidbody.

-**Static**: Un Static Rigidbody 2D está diseñado para no moverse en absoluto en la simulación; si algo colisiona con él, un Static Rigidbody 2D se comporta como un objeto inamovible (como si tuviera una masa infinita). También es el tipo de cuerpo menos intensivo en recursos para usar. Un cuerpo Static solo colisiona con Rigidbody2D Dynamic. Hacer que dos Rigidbody2D Static colisionen no es soportado ya que no están diseñados para moverse.


# Variables
Nombre | Tipo | Dato
--------|--------|--------
angularDrag |	float | Coeficiente de rozamiento angular.
angularVelocity |	float | Velocidad angular en grados por segundo.
drag | float | Coeficiente de arrastre.
freezeRotation | bool | Booleano que controla si la física cambiará la rotación del objeto.
gravityScale | float | El grado en que este objeto está afectado por la gravedad.
inertia | float | La inercia rotacional del rigidBody.
isKinematic | bool | Determina si el objeto debe ser sacado del control del motor de físicas (En caso de ser kinemático)
mass | float | Valor de masa del rigidbody.
position | Vector2 | La posición del rigidbody.
rotation | float | La rotación del rigidbody.
velocity | Vector2 | Velocidad lineal del rigidbody.

# Funciones Públicas
Nombre | Función
--------|--------
AddForce(Vector2 force) | Aplica una fuerza al rigidbody.
AddForceAtPosition(Vector2 force, Vector2 position) | Aplica una fuerza en una posición en el espacio.
AddTorque(float) |	Aplica un torque hacia el centro de masa del rigidbody
IsAwake() | ¿El rigidbody está "despierto"?
IsSleeping() | ¿El rigidbody está "durmiendo"?
MovePosition(Vector2) | Mueve el rigidbody a la posición dada.
MoveRotation(float) | Rota el rigidbody en un ángulo dado.
Sleep() | Hace que el rigidbody "duerma".
WakeUp() | Deshabilita el estado de "dormir" de un rigidbody.

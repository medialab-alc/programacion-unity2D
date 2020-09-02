El componente Rigidbody coloca al objeto bajo el control del motor de físicas de Unity

# Componentes
### Body Type:
El componente Rigidbody 2D tiene una configuración en la parte superior etiquetada como Body Type. La opción que elija para esto afecta otras configuraciones disponibles en el componente y particularmente definirá tanto el comportamiento de movimiento del objeto, como su interacción con los collider.

-**Dynamic**: Un Dynamic Rigidbody 2D está diseñado para moverse bajo simulación. Tiene todo el conjunto de propiedades disponibles, con una masa finita y un valor de arrastre/rozamiento, y se ve afectado por la gravedad y las fuerzas. 
Un cuerpo dinámico permite colisiones con cualquier otro tipo de cuerpo y es el más interactivo. 
Dynamic es la opción predeterminada para un Rigidbody 2D, porque es el tipo de cuerpo más común para los objetos que necesitan moverse. Todas las propiedades un Rididbody2D están disponibles con este tipo de cuerpo.
- No se debe utilizar el componente Transform para establecer la posición o la rotación de un Dynamic Rigidbody 2D. La simulación vuelve a reubicar el Dynamic Rigidbody 2D de acuerdo con su velocidad; se puede cambiar esto directamente a través de fuerzas aplicadas por scripts, o indirectamente a través de colisiones y gravedad.

-**Kinematic**: Un Kinematic Rigidbody 2D está diseñado para moverse bajo simulación pero solo bajo un control definido por parte del usuario. A diferencia de un Dynamic Rigidbody 2D, este no se ve afectado por las fuerzas ni la gravedad. 
Los Rigidbody 2D Kinematic están diseñados para ser reubicados explícitamente a través de Rigidbody2D.MovePosition o Rigidbody2D.MoveRotation. Se utilizan consultas de física para detectar colisiones y scripts para decidir dónde y cómo se moverá el Rigidbody 2D.
Un Rigidbody 2D Kinematic todavía se mueve a través de su velocidad, pero la velocidad no se ve afectada por las fuerzas o la gravedad. Un Rigidbody 2D Kinematic no colisiona con otros Rigidbody 2D Kinematic o con Rigidbody 2Ds Static; solo colisiona con los Rigidbody 2D Dynamic. Durante las colisiones, un Kinematic Rigidbody se comporta como un objeto inamovible (como si tuviera masa infinita), las propiedades de masa no están disponible para este tipo de Rigidbody.

-**Static**: Un Static Rigidbody 2D está diseñado para no moverse en absoluto en la simulación; si algo colisiona con él, un Static Rigidbody 2D se comporta como un objeto inamovible (como si tuviera una masa infinita). También es el tipo de cuerpo menos intensivo en recursos para usar. Un cuerpo Static solo colisiona con Rigidbody2D Dynamic. Hacer que dos Rigidbody2D Static colisionen no es soportado ya que no están diseñados para moverse.

Componente | Función
--------|--------
Body Type | Establece el tipo de Body Type para este rigidbody (Dynamic, Kinematic o Static)
Material | Para aplicar un Physics Material común a todos los collider2D ligados a este Rigidbody, si al Collider2D se le especifica un material propio, utilizará ese, en caso de tener el campo de material vacío, utilizará (de haberlo) el indicado por el Rigidbody2D al que está ligado.
Simulated | Esta casilla está marcada por defecto. En caso de desmarcarse, el Rigidbody2D dejará de formar parte de la simulación de físicas, haciendo que no se vea afectado por fuerzas y gravedad y que la detección de colisiones y puntos de contacto se interrumpa.
Use Auto Mass | Marque la casilla si desea que un Rigidbody 2D detecte automáticamente la masa del GameObject de su Collider 2D.
Mass | Define la masa del Rigidbody 2D. Esta opción está desactivada si seleccionó Use Auto Mass.
Linear Drag | El coeficiente de fricción que afecta el movimiento de posición.
Angular Drag | El coeficiente de fricción que afecta el movimiento de rotación.
Gravity Scale | Define el grado en que un GameObject se ve afectado por la gravedad.
Collision Detection | Define la manera en la que el GameObject calcula los contactos y la posible superposición de los colliders luego de una actualización de físicas.
--Discrete | Cuando configure Collision Detection en Discrete, los GameObjects con Rigidbody 2Ds y Collider 2Ds pueden superponerse entre sí durante una actualización de física si se están moviendo lo suficientemente rápido. Los contactos de colisión solo se generan en la nueva posición.
--Continuous | Cuando Collision Detection se establece en Continuous, los GameObjects con Rigidbody 2Ds y Collider 2Ds no se atraviesan durante una actualización. En cambio, Unity calcula el primer punto de impacto de cualquiera de los Collider 2D, y mueva el GameObject allí. Esto requiere más tiempo de CPU que Discrete.
Sleeping Mode | Define cómo el GameObject “duerme” para ahorrar tiempo del procesador cuando está en reposo.
--Never Sleep | Sleeping está desactivado (esto debe evitarse siempre que sea posible, ya que puede afectar los recursos del sistema).
--Start Awake | El GameObject inicialmente está despierto.
--Start Asleep | El GameObject está inicialmente durmiendo pero se puede despertar por colisiones.
Interpolate | Defina cómo se interpola el movimiento del GameObject entre las actualizaciones de físicas (útil cuando el movimiento tiende a ser desigual).
--None | No se aplica ningún movimiento suavizado.
--Interpolate | El movimiento se suaviza en función de las posiciones de GameObject en cuadros anteriores
--Extrapolate	| El movimiento es suavizado basado en una estimación de su posición en el siguiente cuadro (Frame).
Constraints | Se define cualquier restricción en el movimiento del Rigidbody 2D.
Freeze Position | Permite detener el movimiento del Rigidbody 2D en los ejes X e Y del mundo.
Freeze Rotation | Permite detener la rotación del Rigidbody2D alrededor de los ejes Z.


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

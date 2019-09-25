Input es la clase que nos permite el acceso a la interfaz de Inputs de entrada de Unity.

Si bien no se trata de un componente, se trata de una clase a la cual recurriremos frecuentemente para obtener información sobre los Inputs ingresados por el jugador.

Unity trae preconfigurado un sistema de Inputs tradicional que ya mappea las teclas WASD, Ctrl, Barra Espaciadora, Shift y Cmd, así como el mouse a ciertos Inputs preestablecidos.
Es posible agregar más inputos o modificar los ya existentes mediante el Input Manager (Edit -> Project Settings... -> Input)

En esta primera etapa no estaremos accediendo directamente a las variables estáticas de la clase Input pero si a alguinas de las siguientes funciones/métodos:

## FUNCIONES ESTÁTICAS
NOMBRE | FUNCIÓN
---------- | ----------
GetAxis(string) | Devuelve el valor del eje virtual identificado por el nombre del eje dado, el valor devuelto varía entre -1, 0 y 1 disminuyendo o aumentando en pasos de 0,05 .
GetAxisRaw(string) | Devuelve un valor del eje virtual identificado por el nombre dado, el valor de vuelto varía entre -1, 0 y 1 directamente, sin pasos intermedios.
GetButton(string) | Devuelve true mientras el botón virtual identificado por el nombre dado se mantiene presionado.
GetButtonDown(string) | Devuelve true durante el frame que el usuario presiono el botón virtual identificado por el nombre dado.
GetButtonUp(string) | Devuelve true el primer frame que el usuario soltó el botón virtual indicado.
GetKey(string) | Devuelve true mientras el usuario mantenga presionada la tecla indicada.
GetKeyDown(string) | Devuelve true durante el frame que el usuario empieza a presionar la tecla indicada.
GetKeyUp(string) | Devuelve true durante el frame que el usuario soltó la tecla indicada.
GetMouseButton(int) | Devuelve true si se mantiene oprimido el botón del mouse.
GetMouseButtonDown(int) | Devuelve true durante el frame que el usuario presiono el botón del mouse dado.
GetMouseButtonUp(int) | Devuelve true durante el frame que el usuario soltó el botón del mouse dado.

**Nota 1: En todos los casos de GetAxis, GetButton o GetKey, el string que se provee a la función debe corresponder con el nombre dado a dicho eje, botón o tecla, dichos nombres pueden verse en el Input Manager**

**Nota 2: En el caso de GetMouseButton, el número entero dado es uno de 3 opciones: 0 representa al botón izquierdo, 1 representa al botón derecho y 2 representa al botón central del mouse.**

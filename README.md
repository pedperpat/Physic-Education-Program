# Physic-Education-Program Windows Forms

Repaso / Calculadora de física usando Windows Forms

---DONE!--- 1º Entrega: Crear el esqueleto principal del proyecto con pantalla de inicio, botones y varias ventanas contiguas que aparezcan al apretar dichos botones y cada ventana tenga diferentes opciones a elegir.

---DONE!--- 2º Entrega: Crear una ventana de presentación con mi nombre, la versión actual y el changelog actual. También meter contenido a cada ventana como términos y conceptos importantes sobre física.

---DONE!--- 3º Entrega: Añadir los valores de las constantes, para que al pulsar sobre el botón que ponga: "Ir a ver constantes..." lleve al usuario a la ventana con todas las constantes y poder buscar en un buscador la constante que necesite.

---DONE---! 4º Entrega: Hacer que vaya calculando pequeñas ecuaciones de posición inicial,posición final, Hmax,etc. El usuario introducirá en un textbox los valores a partir de los cuales serán calculadas las ecuaciones. El resultado será visible a través de otro textbox de solo lectura. Además hacer correcciones y comprobar que no se puedan introduzcan datos de otro tipo. 

---DONE---! 5º Entrega: Una vez obtenida la solución a la ecuación que el usuario ha querido saber, se activará un botón para que pueda(en el caso de que quiera) exportar dicha solución a un archivo de texto plano.

---DONE---! 6º Entrega: 
- Hacer que cuando se le dé a solve en la clase acceleration se autoguarde en un archivo predefinido y con extensión .phy,que irá en la carpeta bin/debug y será el histórico de todas las soluciones resueltas por el programa.
- Ahora para cargar el archivo de antes,debes hacer una clase llamada "Historical" se cargará el archivo de antes directamente a un richtextbox**(Puedes ayudarte de un textreader ya que te simplificará bastante el proceso de carga y de muestra de los datos, no te olvides de cerrar el archivo una vez hayas terminado de trabajar con él ;) )**
- Nota: Fijate bien en la clase acceleration para que puedas ver el formato con el que se guardan los archivos, dicho formato está en el método: **exportResultToAFileToolStripMenuItem_Click** a la hora de guardar el string, ayudate de él para realizar el archivo de historial.

---DELAYED---!7º Entrega: Añadir muchas más ecuaciones de física como tiros parabólicos, energía cinética, volumen y presiones. Arreglar el fallo de que no se cierran las ventanas bien y terminar de hacer la parte visual y de lógica de ecuaciones que faltan por hacer.

8º Entrega: En la misma ventana de elegir el tipo de ecuación, una vez seleccionada la ecuación que se quiere obtener la solución, dar a elegir entre introducir los datos a mano o cargar un fichero de texto con los datos necesarios en el formato correcto.

---DELAYED---!9º Entrega: En la misma ventana de la solución a la ecuación,hacer mediante un chart que dibuje la gráfica de la ecuación si puede ser posible.

---DONE---! 10º Entrega: Pasar todo texto de botones, menús, conceptos y términos a inglés y español para hacerlo multilingüe.(1)

---DONE---! 11º Entrega: Pasar todo texto de botones, menús, conceptos y términos a inglés y español para hacerlo multilingüe.(2)

---DELAYED---!12º Entrega: Añadir nuevas ecuaciones de varios temas: termodinámica, momento de fuerza, aceleración angular, período y frecuencia,leyes de Newton,etc...

---DONE---!13º Entrega: Dar la opción al usuario de descargar problemas de física desde una página web con tandas de problemas y además poner un visor para que se conecte a un canal de youtube dedicado a ayuda y a videotutoriales sobre cómo resolver y calcular problemas de física.

---DONE---!14º Entrega: Interactuar con el usuario; repaso de problemas, el usuario pide un problema, una vez resuelto pone el resultado en el textbox y el programa sacará un tick verde si el resultado ha sido correcto o un tick rojo si el resultado del usuario ha sido incorrecto y además mostrará la solución verdadera.

15º Entrega: Retoques finales a todos los apartados y pasar a varios idiomas las opciones que se han ido poniendo hasta la fecha. Comprobar que todo funcione como es debido y solucionar pequeños detalles puntuales.

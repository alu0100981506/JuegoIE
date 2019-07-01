# Juego_Interfaces_Inteligentes
proyecto final

# Hitos logrados en la realización de la práctica:
 
 * __Enemigos__: El prefeb para los enemigos lo hemos tomado de diversas assets de la store. Éstas incluían varios personajes con 
 distintas
 animacione, pero nosotros creamos el animator para asociarlas. De esta forma, los enemigos tienen animaciones para el movimiento, ataque
 y muerte, habiendo varias posibilidades para cada uno. Respecto a la inteligencia de los zombies, utilizamos la tecnología NavMesh para 
 hacer que los enemigos se dirigieran siempre hacia el personaje.
 
 * __Mapa__: Utilizamos un terrain como base y añadimos distintos formatos de paredes, con texturas diversas. Además, añadimos un SkyBox para
 adornar el cielo. Para que tuviera cierta ambientación, añadimos niebla, que se activa de manera aleatoria en las rondas, así como hogueras
 que se encienden en rondas determinadas. En ambas utilizamos delegas para su control.
 
 * __Personaje__: El "protagonista" dispone de dos armas distintas: un arma de fuego y una katana, pudiendo intercambiar entre ambas. Tanto para
 el disparo del rifle como para el ataque de la katana, tuvimos que hacer las animaciones, así como para el cambio de arma.
 
 * __Interfaz__: Se encuentra en el cielo, mostrando vida, ronda y las balas restantes del arma de fuego. 
 
 * __Controles__: Para el manejo del personaje utilizamos un mando de Xbox:
 
   * LB: Ataque
   * A: Saltar/Iniciar Partida
   * B/Y: Cambiar de arma
   * X: Recargar el arma de fuego
   * Joystikc izquierdo: Mover al personaje
 
 * __Distribución de la tareas y trabajo en equipo__: A la hora de realizar el proyecto, por lo general, trabajabamos todos de manera conjunta, 
 usualmente de forma remota a través de Discord. Distribuir el trabajo de manera correcta sería complicado, ya que todos trabajos de alguna
 manera en los apartados que realizaron los demás, pero, a grandes rasgos, Alberto se ocupó del GameController, la carga de niveles y 
 el canvas; Pablo realizó el mapa y añadió la niebla y las hogueras; y Javier trabajó con el movimiento del personaje y los enemigos.

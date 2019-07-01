# Juego_Interfaces_Inteligentes

* __Descarga del APK__: https://drive.google.com/file/d/1WgajQ2EYZ8zkrqfxoD5xTD7qER3rih_v/view?usp=drivesdk

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
 
 * __Distribución de la tareas y trabajo en equipo__: A la hora de realizar el proyecto, por lo general, trabajabamos todos de manera conjunta, usualmente de forma remota a través de Discord. Distribuir el trabajo de manera correcta sería complicado, ya que todos trabajos de alguna manera en los apartados que realizaron los demás, pero, a grandes rasgos: 
   * Alberto se ocupó del canvas, particulas(niebla, hogueras) y sus delegados, y del control de niveles 
   * Pablo realizó el mapa, el gamecontroller y la configuración del NavMesh 
   * Javier trabajó con los movimientos del personaje, se encargo  de las animaciones, y del disparo del arma.
   
   
   
 * __Gifs del juego__
 
   * En este gif del juego se puede apreciar el hud y la animación asociada al disparo del arma principal.
 
 ![Hud+Disparar](Gifs/Hud+Disparar.gif)
 
 
   * Aqui se puede ver la animacion de muerte de un zombie y la animación de cambio del arma principal a la secundaria.
 
 ![Muerte_Zombie+Cambio_katana](Gifs/Muerte_Zombie+Cambio_katana.gif)
 
   * GamePlay del juego en el cual se ve el manejo de la katana, asi como su animacion.
 
 ![Gameplay_katana](Gifs/Gameplay_katana.gif)
 
   * Efecto de particulas de las hogueras
 
 ![Hoguera](Gifs/Hoguera.gif)
 
   * Por ultimo se puede ver la niebla y que al acabar con todos los zombies de la ronda, esta se actualiza en el HUD
 
 ![Fog+Cambio_Ronda](Gifs/Fog+Cambio_Ronda.gif)
 

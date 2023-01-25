# Patrones de Diseño

# OBSERVABLE :
Se implementa patron de diseño Observable mediante las clases Stock implementado una interfaz IObservable encargada de 
suscribir y des-suscribir los observadores, una clase stock implementando una interfaz Iobserver encargada de des-suscribirse del objeto a observar
y notificar cuando un objeto ha sufrido cambios.

# FACTORY METHOD :
Se implementa patron de diseño Factory implementando una interfaz IWeapon encargada de asiganar un comportamiento a las clases hijas y mediante una
clase WeaponFactory realizar una instancia de una clase u otra segun su comportambiento.

# SINGLETON :
Se implementa patron de diseño Singleton asegurando de que una clase Logger solo pueda tener una instancia de dicha clase.

# STRATEGY :
Se implementa patron de diseño estrategy en un contexto player el cual define el tipo de movimiento mediantes las clases Walk y Fly las cuales al implementar la interfaz 
IMovement obliga a las clases a implementar el metodo Move, y desde la clase "Main" llamada Game podemos definir y modificar el tipo de estrategia de movimiento que deseamos que el jugador (Player) ejecute en ese momento.


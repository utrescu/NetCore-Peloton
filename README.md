# Entrando en pelotón

El programa és un dels exercicis del ProgramaMe de l'any 2018

> Tiempo máximo: 1,000-2,000 s Memoria máxima: 4096 KiB

## Pelotón ciclista

Cuando en una vuelta ciclista los corredores llegan en pelotón, todos reciben el mismo tiempo para esa etapa, incluso aunque no hayan llegado exactamente en el mismo instante. Se hace así porque es físicamente imposible, por obvios motivos de espacio, que todos lleguen a la vez. De modo que para evitar accidentes (y, por qué no decirlo, simplificar la gestión), se les asigna a todos el mismo tiempo y problema resuelto.

Ahora eso sí, en cuanto hay un corte entre dos ciclistas, se utiliza para el rezagado el tiempo real en el que haya llegado. Si detrás de él llega un segundo pelotón, todos ellos tendrán el mismo tiempo, otra vez.

### Entrada

El programa deberá leer, por cada caso de prueba, un primer número 1 ≤ n ≤ 100 indicando el número de corredores que han conseguido terminar la etapa.

A continuación, vendrán n líneas con los tiempos de esos corredores en formato HH:MM:SS, indicando las horas, minutos y segundos reales que ha tardado cada uno en llegar a la meta (nunca más de 24 horas). Por razones que se desconocen, la organización proporciona los tiempos en orden arbitrario.

### Salida

Por cada caso de prueba se escribirá la posición de llegada de cada corredor, en el mismo orden en el que se recibieron en la entrada. Todos los corredores que son calificados con el mismo tiempo de llegada (tras la agrupación por el pelotón) deben recibir el mismo puesto. Se considera que se ha producido un corte de corredores si su distancia en tiempo es mayor que un segundo.

Después de cada caso de prueba el programa escribirá una línea con tres guiones (---).

    Entrada de ejemplo

    3
    01:01:01
    01:00:59
    01:01:00
    3
    01:03:00
    01:01:00
    01:01:00

Salida de ejemplo

    1
    1
    1
    ---
    3
    1
    1

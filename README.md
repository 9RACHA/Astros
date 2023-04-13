# Astros

Realizar un proyecto en Unity llamado Astros con las siguientes especificaciones.
El objetivo del proyecto es mostrar en la consola de Unity información sobre astros del sistema
solar para lo que precisamos las clases Astro, Estrella, Planeta y Satelite, que deben ser
programadas por el alumno.

##Clase Astro.
La clase Astro debe ser una clase declarada abstracta de la que derivarán las otras tres. Contiene la
funcionalidad común a todos los astros. Debe incluir lo siguiente:
Un tipo enumerado público, llamado ClaseAstro, que tendrá como miembros los valores
Estrella, Planeta, Satelite.
Un campo de tipo ClaseAstro llamado claseAstro.
Un campo de tipo string llamado nombre.
Dos campos de tipo float llamados masa y diametro.
Todos estos campos deben ser accesibles solo a la propia clase Astro y a las que de ella deriven.
Un campo de tipo List<Astro> llamado astrosOrbitantes. Este campo debe ser públicamente
accesible.
Un constructor público que reciba como parámetros valores para los campos claseAstro, nombre,
masa y diametro y los asigne a estos campos. Debe respetarse el orden de los parámetros.
Un método público llamado Info(), sin parámetros, que devolverá la concatenación de la clase del
astro, su nombre, su masa y su diámetro formateada como en este ejemplo:
Estrella: Sol, masa: 1,989E+30, diametro: 1391016
El método Info() debe estar declarado para poder ser sobreescrito en las clases que deriven de
Astro.
Un método abstracto llamado AddAstroOrbitante(), que recibirá como parámetro un objeto de la
clase Astro.

Clase Estrella
La clase Estrella descenderá de Astro.
El constructor de la clase Estrella recibirá como parámetros valores para los campos nombre,
masa y diametro. Invocará al constructor de la clase base, pasando en el primer parámetro,
correspondiente a claseAstro, el valor ClaseAstro.Estrella. Además inicializará el campo
astrosOrbitantes como una List<Astro> vacía.
La implementación del método AddAstroOrbitante() comprobará que el parámetro Astro
suministrado es de la clase Planeta y si lo es, lo añadirá a la lista astrosOrbitantes.
  
Clase Planeta
La clase Planeta descenderá de Astro.
El constructor de la clase Planeta recibirá como parámetros valores para los campos nombre, masa
y diametro. Invocará al constructor de la clase base pasando en el primer parámetro,
correspondiente a claseAstro, el valor ClaseAstro.Planeta. Además inicializará el campo
astrosOrbitantes como una List<Astro> vacía.
La implementación del método AddAstroOrbitante() comprobará que el parámetro Astro
suministrado es de la clase Satelite y si lo es, lo añadirá a la lista astrosOrbitantes.
Se sobreescribirá el método Info(). El método devolverá el string "--->" concatenado con el
valor devuelto por el método Info() de la clase base.

Clase Satelite
La clase Satelite descenderá de Astro.
El constructor de la clase Satelite recibirá como parámetros valores para los campos nombre,
masa y diametro. Invocará al constructor de la clase base pasando en el primer parámetro,
correspondiente a claseAstro, el valor ClaseAstro.Satelite. No hará nada más, ya que los
satélites no tienen otros astros orbitante en torno a ellos y, por lo tanto, esta clase no hace uso de la
lista de astros orbitante.
En consecuencia, la implementación del método AddAstroOrbitante() no hará nada, pero es
necesario implementarlo.
Se sobreescribirá el método Info(). El método devolverá el string "------->" concatenado con
el valor devuelto por el método Info() de la clase base.

Programa principal
Se suministra el archivo Main.cs que contiene un script a modo de programa principal. El método
Start() de este script crea objetos de las clases Estrella, Planeta y Satelite, representando el
sol y otros objetos del sistema solar, y los vincula usando el método AddAstroOrbitante() para
después listar la información disponible usando el método Info(). Las clases creadas siguiendo la
especificación funcionarán correctamente con este programa principal y mostrarán un listado como
este:
  
Estrella: Sol, masa: 1,989E+30, diametro: 1391016
--->Planeta: Mercurio, masa: 3,302E+23, diametro: 4879
--->Planeta: Venus, masa: 4,869E+24, diametro: 12103
--->Planeta: Tierra, masa: 5,973E+24, diametro: 12742
------->Satelite: Luna, masa: 7,349E+22, diametro: 3474
--->Planeta: Jupiter, masa: 1,899E+27, diametro: 142984
------->Satelite: Ío, masa: 8,94E+22, diametro: 3643
------->Satelite: Europa, masa: 4,8E+22, diametro: 3121
------->Satelite: Ganimedes, masa: 1,482E+23, diametro: 5268
------->Satelite: Calisto, masa: 1,076E+23, diametro: 4820
--->Planeta: Saturno, masa: 5,688E+26, diametro: 120536
------->Satelite: Mimas, masa: 3,749E+19, diametro: 397
------->Satelite: Encélado, masa: 1,08E+20, diametro: 504
------->Satelite: Tetis, masa: 6,1745E+20, diametro: 1060
[...]

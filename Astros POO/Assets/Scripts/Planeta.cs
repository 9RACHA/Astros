using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//La clase Planeta descendera de Astro
public class Planeta : Astro {

    //Constructor
    /*El constructor de la clase Planeta recibira como parametros valores para los campos nombre,masa y diametro.*/
    public Planeta(string nombre, float masa, float diametro) : base(ClaseAstro.Planeta, nombre, masa, diametro) {
    }//Invocara al constructor de la clase base, pasando en el 1º parametro, claseAstro, el valor ClaseAstro.Planeta
    //------------------------------------------------
    //Ademas inicializara el campo astrosOrbitantes como una List<Astro> vacia.

    //Metodo para añadir un satelite orbitante
    /*La implementacion del metodo AddAstroOrbitante() comprobara que el parametro Astro */
    public override void AddAstroOrbitante(Astro astro) {
        if (astro is Satelite) { //suministrado es de la clase Satelite y si lo es,
            astrosOrbitantes.Add(astro); //lo añadira a la lista astrosOrbitantes
        }
    }

    //Metodo para imprimir la informacion del planeta,sobrescribe el metodo base
    /*Se sobreescibira el metodo Info().El metodo devolverá string*/
    public override string Info() {
        return $"--->{base.Info()}"; // "--->" concatenado con el valor devuelto por el metodo Info() de la clase base.
    }
}


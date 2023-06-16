using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrella : Astro { //La clase estrella descendera de Astro
    //Constructor
    /*El constructor de la clase Estrella recibirá como parametros valores para los campos
    nombre, masa y diametro.*/
    public Estrella(string nombre, float masa, float diametro) : base(ClaseAstro.Estrella, nombre, masa, diametro) {
    //Invocara al constructor de la clase base, pasando en el 1º parametro correspondiente a claseAstro, el valor claseAstro el valor ClaseAstro.Estrella
    // AstrosOrbitantes = new List<Astro>();
    //************************************************************************************************ REVISAR
     //ADEMAS INICIALIZARA EL CAMPO astrosOrbitantes como una List<Astro> vacia.
    }

    /*La implementacion del metodo AddAstroOrbitante() comprobara que el parametro Astro suministrado*/
    //Metodo para añadir un planeta orbitante
    public override void AddAstroOrbitante(Astro astro) {
        if (astro is Planeta) {// es de la clase Planeta y si lo es 
            astrosOrbitantes.Add(astro);//lo añadira a la lista astrosOrbitantes
        }
    }
}


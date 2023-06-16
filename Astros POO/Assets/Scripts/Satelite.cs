using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//La clase Satelite descendera de Astro
public class Satelite : Astro
{
    //Constructor
    /*El constructor de la clase Satelite recibira como parametros valores para los campos nombre, masa, diametro*/
    public Satelite(string nombre, float masa, float diametro) : base(ClaseAstro.Satelite, nombre, masa, diametro) {
        //Invocara al constructor de la clase base pasando en el 1º parametro, correspondiente a claseAstro, el valor ClaseAstro.Satelite.
        //No hara nada mas ya que los satelites no tienen otros astros orbitantes en torno a ellos, y por tanto, esta 
        //clase no hace uso de la lista astro orbitante.
    }

    //metodo para añadir un astro, esta vacio
    /*En consecuencia la implementacion del metodo AddAstroOrbitante() no hará nada, pero es necesario implementarlo*/
    public override void AddAstroOrbitante(Astro astro)
    {
        // No hace nada
    }

    //Se sobreescribira el metodo Info().
    public override string Info()
    {
        return $"------->{base.Info()}"; //El metodo devolvera el string "----->" concatenado con el valor devuelto por el metodo Info() de la clase base
    }
}


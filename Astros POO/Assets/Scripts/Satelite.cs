using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satelite : Astro
{
    //Constructor
    public Satelite(string nombre, float masa, float diametro) : base(ClaseAstro.Satelite, nombre, masa, diametro) {
    }

    //metodo para añadir un astro, esta vacio
    public override void AddAstroOrbitante(Astro astro)
    {
        // No hace nada
    }

    public override string Info()
    {
        return $"------->{base.Info()}";
    }
}


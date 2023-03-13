using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : Astro {
    //Constructor
    public Planeta(string nombre, float masa, float diametro) : base(ClaseAstro.Planeta, nombre, masa, diametro) {
    }

    //Metodo para añadir un satelite orbitante
    public override void AddAstroOrbitante(Astro astro) {
        if (astro is Satelite) {
            astrosOrbitantes.Add(astro);
        }
    }

    //Metodo para imprimir la informacion del planeta,sobrescribe el metodo base
    public override string Info() {
        return $"--->{base.Info()}";
    }
}


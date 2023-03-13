using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrella : Astro {
    //Constructor
    public Estrella(string nombre, float masa, float diametro) : base(ClaseAstro.Estrella, nombre, masa, diametro) {
    }

    //Metodo para añadir un planeta orbitante
    public override void AddAstroOrbitante(Astro astro) {
        if (astro is Planeta) {
            astrosOrbitantes.Add(astro);
        }
    }
}


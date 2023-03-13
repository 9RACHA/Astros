using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   public abstract class Astro {

    //Enumeracion para identificar el tipo de astro
    public enum ClaseAstro { Estrella, Planeta, Satelite };

    //Campos
    // Pueden ser accedido por clases derivadas con protected
    protected ClaseAstro claseAstro;
    protected string nombre;
    protected float masa;
    protected float diametro;
    public List<Astro> astrosOrbitantes;

    //Constructor
    public Astro(ClaseAstro claseAstro, string nombre, float masa, float diametro) {
        this.claseAstro = claseAstro;
        this.nombre = nombre;
        this.masa = masa;
        this.diametro = diametro;
        astrosOrbitantes = new List<Astro>();
    }

    //Metodo abstracto para añadir un astro orbitante
    public abstract void AddAstroOrbitante(Astro astro);

    //Metodo para imprimir informacion del astro
    public virtual string Info() {
        return $"{claseAstro}: {nombre}, masa: {masa:E}, diametro: {diametro}";
    }
}

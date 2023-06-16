using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*La clase Astro debe ser una clase declarada abstracta de la que derivaran las otras 3.
Contiene la funcionalidad comun a todos los astros. Debe incluir lo siguiente:*/
public abstract class Astro {

    //Enumeracion para identificar el tipo de astro
    /*Un tipo enumerado publico, llamado ClaseAstro, que tendra como miembros los valores Estrella,Planeta,Satelite*/
    public enum ClaseAstro { Estrella, Planeta, Satelite };

    //Campos
    // Pueden ser accedido por clases derivadas con protected
    protected ClaseAstro claseAstro; //Un campo de tipo ClaseAstro llamado claseAstro
    protected string nombre; //Un campo de tipo string llamado nombre
    protected float masa; //2 campos de tipo float llamados masa y diametro
    protected float diametro;
    //Todos estos campos deben ser accesibles solo a la propia clase Astro y a las que de ella deriven - protected

    /*Un campo de tipo List<Astro> llamado astrosOrbitantes*/
    public List<Astro> astrosOrbitantes; //este campo debe ser publicamente accesible

    /*Un constructor publico que reciba como parametros valores para los campos claseAstro,*/
    public Astro(ClaseAstro claseAstro, string nombre, float masa, float diametro) {//nombre, masa, diametro
    // y los asigne a estos campos. Debe respetarse el orden de los parametros.
        this.claseAstro = claseAstro;
        this.nombre = nombre;
        this.masa = masa;
        this.diametro = diametro;
        astrosOrbitantes = new List<Astro>();
    }

    //Metodo para imprimir informacion del astro
    /*Un metodo publico llamado Info() sin parametros*/
    public virtual string Info() {//El metodo Info() debe estar declarado para poder ser sobreescrito en las clases que deriven de Astro
        //que devolvera la concatenacion de la clase del astro, su nombre, su masa y su diametro.
        return $"{claseAstro}: {nombre}, masa: {masa:E}, diametro: {diametro}";
        // Estrella: Sol, masa: 1,989E+30, diametro: 1391016
    }

    //Metodo abstracto para añadir un astro orbitante
    public abstract void AddAstroOrbitante(Astro astro);
    //Un metodo abstracto llamado AddAstroOrbitante(), que recibira como parámetro un objeto de la clase Astro

    
}

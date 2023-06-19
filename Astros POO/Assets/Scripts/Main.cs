using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se suministra el archivo Main que contiene un script a modo de programa principal
public class Main : MonoBehaviour
{
    //El metodo Start() de este script crea objetos de las clases Estrella,Planeta y Satelite
    //representando el sol y otros objetos del sistema solar
    void Start()
    {
        Estrella sol = new Estrella("Sol", 1.989e30f, 1391016f);
        Planeta mercurio = new Planeta("Mercurio", 3.302e23f, 4879f);
        Planeta venus = new Planeta("Venus", 4.869e24f, 12103.6f);
        Planeta tierra = new Planeta("Tierra", 5.973e24f, 12742f);
        Satelite luna = new Satelite("Luna", 7.349e22f, 3474f);
        Planeta marte = new Planeta("Marte", 1.899e27f, 139822f);

        // y los vincula usando el metodo AddAstroOrbitante()
        sol.AddAstroOrbitante(mercurio);
        sol.AddAstroOrbitante(venus);
        sol.AddAstroOrbitante(tierra);
        tierra.AddAstroOrbitante(luna);
        sol.AddAstroOrbitante(marte);

        //para despues listar la informacion disponible usando el metodo Info()
        Debug.Log(sol.Info());
        //Las clases creadas siguiendo la especificacion funcionaran correctamente con este programa principal
        //y mostraran un listado
        /*Foreach: es especialmente útil cuando se trabaja con colecciones como arrays, listas
        foreach (tipoElemento variable in coleccion)
        {
        // Código a ejecutar para cada elemento
        }
        tipoElemento: es el tipo de dato de los elementos de la colección.
        variable: es una variable que representa cada elemento de la colección en cada iteración.
        coleccion: es la colección o secuencia de datos sobre la cual se itera.*/
        foreach (Astro astro in sol.astrosOrbitantes)
        {
            Debug.Log(astro.Info());
            if (astro is Planeta)
            {
                foreach (Astro astroOrbitante in astro.astrosOrbitantes)
                {
                    Debug.Log("--->" + astroOrbitante.Info());
                }
            }
            else if (astro is Satelite)
            {
                Debug.Log("------->" + astro.Info());
            }
        }
    }
}

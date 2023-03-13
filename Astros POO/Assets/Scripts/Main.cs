using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        Estrella sol = new Estrella("Sol", 1.989e30f, 1391016f);
        Planeta mercurio = new Planeta("Mercurio", 3.302e23f, 4879f);
        Planeta venus = new Planeta("Venus", 4.869e24f, 12103.6f);
        Planeta tierra = new Planeta("Tierra", 5.973e24f, 12742f);
        Satelite luna = new Satelite("Luna", 7.349e22f, 3474f);
        Planeta jupiter = new Planeta("Jupiter", 1.899e27f, 139822f);

        sol.AddAstroOrbitante(mercurio);
        sol.AddAstroOrbitante(venus);
        sol.AddAstroOrbitante(tierra);
        tierra.AddAstroOrbitante(luna);
        sol.AddAstroOrbitante(jupiter);

        Debug.Log(sol.Info());
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

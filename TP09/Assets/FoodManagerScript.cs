using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManagerScript : MonoBehaviour
{
    public GameObject[] Comidas;
    int Comida1, Comida2, OpcionCorrecta;
    int[] Opciones = { 0,0,0 };
    private void Start()
    {
        Comida1 = Random.Range(0, 16); Comida2 = Random.Range(0, 16); OpcionCorrecta = Random.Range(0, 2);
        while (Opciones[0] == Opciones[1] || Opciones[0] == Opciones[2] || Opciones[1] == Opciones[2] || Opciones[1] == Comida2 || Opciones[2] == Comida2 || Opciones[0] == Comida2)
        {
            for (int i = 0; i < 3; i++)
            {
                Opciones[i] = Random.Range(0, 16);
            }
        }
        Opciones[OpcionCorrecta] = Comida2;
    }

}

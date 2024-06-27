using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodManager : MonoBehaviour
{
    public GameObject[] Comidas;
    int Comida1, Comida2, OpcionCorrecta;
    int[] Opciones = {0, 0, 0};
    int OpcionSeleccionada;
    private void Start()
    {
        Comida1 = Random.Range(0, 16);
        Comida2 = Random.Range(0, 16);
        OpcionCorrecta = Random.Range(0, 2);
        for(int i = 0; i<3; i++)
        {
            Opciones[i] = Random.Range(0, 16);
        }
        for(int i = 0; i<3; i++)
        {
            if (Opciones[i] == Comida2)
            {
                Opciones[i] = Random.Range(0, 16);
            }
        }
        if(Opciones[0] == Opciones[1] || Opciones[0] == Opciones[2]|| Opciones[0] == Comida2)
        {
            Opciones[0] = Random.Range(0, 16);
        }
        if (Opciones[1] == Opciones[0] || Opciones[1] == Opciones[2] || Opciones[1] == Comida2)
        {
            Opciones[1] = Random.Range(0, 16);
        }
        if (Opciones[2] == Opciones[1] || Opciones[2] == Opciones[0] || Opciones[2] == Comida2)
        {
            Opciones[2] = Random.Range(0, 16);
        }
        Opciones[OpcionCorrecta] = Comida2;
    }
    private void Update()
    {
        
    }

}

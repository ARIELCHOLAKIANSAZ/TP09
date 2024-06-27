using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodManagerScript : MonoBehaviour
{
    public GameObject[] Comidas;
    int Comida1, Comida2, OpcionCorrecta;
    int[] Opciones = { 0,0,0 };
    public Text[] Precios;
    int OpcionSelec = 4;
    
    
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
        string Precio;
        Debug.Log(GameObject.Find(Comidas[Opciones[0]].name).GetComponent<Producto>().precio);

        for (int i = 0; i < 3; i++)
        {
            Debug.Log(GameObject.Find(Comidas[Opciones[i]].name).GetComponent<Producto>().precio);
            Precio = GameObject.Find(Comidas[Opciones[i]].name).GetComponent<Producto>().precio.ToString();
            Precios[i].text = Precio;
        }

    }

    public void Respuestar()
    {
        if(OpcionSelec == 4)
        {
            
        }
    }
}

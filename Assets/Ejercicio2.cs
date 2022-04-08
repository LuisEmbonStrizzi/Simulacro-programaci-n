using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public float PrecioProd1;
    public float PrecioProd2;
    public float PrecioProd3;
    public float DineroDisponible;
    float suma;
    float DineroSobrante;
    float DineroFaltante;
    // Start is called before the first frame update
    void Start()
    {
        suma = PrecioProd1 + PrecioProd2 + PrecioProd3;
        DineroSobrante = DineroDisponible - suma;
        DineroFaltante = suma - DineroDisponible;
        if (suma > DineroDisponible)
        {
            Debug.Log("La suma supera el dinero disponible");
            Debug.Log("Falta: $" + DineroFaltante);
        }
        else
        {
            Debug.Log("La suma no supera el dinero disponible");
            Debug.Log("Sobra: $" + DineroSobrante);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Se ejecuta cuando el jugador entra en contacto con otro objeto
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Colisión con: " + col.gameObject.name);
    }

    // Se ejecuta mientras el jugador permanece en contacto con otro objeto
    void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log("Manteniendo colisión con: " + col.gameObject.name);
    }
}

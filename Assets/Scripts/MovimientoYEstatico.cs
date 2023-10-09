using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoYEstatico : MonoBehaviour
{
    public float magnitudVelocidad = 5;
    Rigidbody2D fisicas;
    private bool detener = false;
    private float tiempoDetenido = 2.0f;
    private float tiempoColision;

    void Start()
    {
        fisicas = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (detener && Time.time - tiempoColision >= tiempoDetenido)
        {
            detener = false;
        }

        if (!detener)
        {
            float movimientoHorizontal = Input.GetAxis("Horizontal");
            float movimientoVertical = Input.GetAxis("Vertical");
            Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical);

            fisicas.velocity = movimiento * magnitudVelocidad;
        }
        else
        {
            fisicas.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            detener = true;
            tiempoColision = Time.time;
        }
    }
}
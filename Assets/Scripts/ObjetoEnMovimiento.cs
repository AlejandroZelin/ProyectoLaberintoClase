using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoEnMovimiento : MonoBehaviour
{
    private float movY;
    bool haciaArriba;
    public float Velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vigilarDireccion();
        mover();
    }

    void vigilarDireccion() 
    {
        if (transform.position.y > 3)
        {
            haciaArriba = false;
        }

        else if (transform.position.y < -4)
        {
            haciaArriba = true;
        } 
    }
    void mover()
    {
        if (haciaArriba == true)
        {
            transform.Translate(Velocidad * Vector2.up * Time.deltaTime);
        }
        else
        {
            transform.Translate(Velocidad * Vector2.down * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    private float rotZ;
    public float RotationSpeed;
    public bool Objeto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Objeto == false)
        {
            rotZ += Time.deltaTime * RotationSpeed;
        }
        else 
        {
            rotZ += Time.deltaTime * RotationSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}

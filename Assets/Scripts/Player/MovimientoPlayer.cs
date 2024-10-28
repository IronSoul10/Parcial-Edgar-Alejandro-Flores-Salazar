using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    protected float velocidad = 1000f;
    protected Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Mover();
    }
    void Mover()
    {
        rb.velocity = new Vector3(MoverHorizontal(),0,0) * velocidad;
    }
    public float MoverHorizontal()
    {
        return Input.GetAxis("Horizontal");

    }
}



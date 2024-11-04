using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    private float velocidad = -800f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, Movimiento().z);
    }

    Vector3 Movimiento()
    {
        return transform.forward * velocidad;
    }
}


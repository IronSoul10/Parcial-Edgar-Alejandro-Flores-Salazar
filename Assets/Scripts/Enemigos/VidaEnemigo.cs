using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    private ContadorBajas contador;

    private void Start()
    {
        contador = FindObjectOfType<ContadorBajas>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bala"))
        {
            contador.EnemigoDestruido();
            Destroy(this.gameObject);
        }
    }


}


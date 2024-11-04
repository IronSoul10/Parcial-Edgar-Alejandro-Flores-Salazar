using UnityEngine;

public class Bala : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemigo"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}


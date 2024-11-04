using System.Collections;
using UnityEngine;


public class Arma : MonoBehaviour
{
    public float velocidadBala;
    public GameObject balaPrefab;
    public Transform puntoTiro;
    bool armaEstaFria = true; // no se por que de a huevo tengo que ponerlo en true si ya solo deberia ser true, pero bueno 

    void Update()
    {
       AccionarArma();
    }
    void AccionarArma()
    {
        if (JalaGatillo() && armaEstaFria)
        {
            Disparar();
            StartCoroutine(ColdDown());
        }
    }
    bool JalaGatillo()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    void Disparar()
    {
        GameObject clone = Instantiate(balaPrefab, puntoTiro.position, Quaternion.LookRotation(Vector3.forward));// blmpre vienso hacia zoque la direccion donde sale la bala para que sea sie
        Rigidbody rb = clone.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * velocidadBala); //quite el transform.forward por que hacia contradireccion a la bala y no se movia
        Destroy(clone, 10);
    }
    IEnumerator ColdDown()
    {
       armaEstaFria = false;

       yield return new WaitForSeconds(0.5f);

       armaEstaFria = true;
    }
}

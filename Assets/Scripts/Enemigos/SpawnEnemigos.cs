using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public Transform puntoInicio;
    public float velEnemigo;
    bool spawnActivo = true;
    
    [HideInInspector]
    public Vector3 rotacion;

     void Update()
    {
       SpawnEnemigo();
    }
    void SpawnEnemigo()
    {
        if (spawnActivo)
        {
            float posicionX = Random.Range(-600f, 600f);
            Vector3 posicionSpawn = new Vector3(posicionX, 0, 500);

            Quaternion rotacionQuaternion = Quaternion.Euler(rotacion);
            GameObject clone = Instantiate(enemigoPrefab, posicionSpawn, rotacionQuaternion);
            Rigidbody rb = clone.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward * 10f);
            Destroy(clone, 20);
            StartCoroutine(ColdDown());
        }
    }

    IEnumerator ColdDown()
    {
        spawnActivo = false;
        yield return new WaitForSeconds(1f);
        spawnActivo = true;
    }
}

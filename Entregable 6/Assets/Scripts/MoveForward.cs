using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Velocidad del proyectil
    private float speed = 10f;

    // Límite de X e Y
    private float xRange = 10;
    private float yRange = 5;

    // Update is called once per frame
    void Update()
    {
        // Movimiento del proyectil
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Revisa si el proyectil llega a los límites
        if (transform.position.x > xRange
            || transform.position.x < -xRange
            || transform.position.y > yRange
            || transform.position.y < -yRange)
        {
            // Destruye el proyectil
            Destroy(gameObject);
        }
    }
}

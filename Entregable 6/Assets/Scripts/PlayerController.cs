using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Recibe variables de tipo Quaternion
    private Quaternion rotation;

    // Almacena el prefab del proyectil
    public GameObject projectilePrefab;

    // Direcciones del disparo
    private Vector3 shootHorizontal = new Vector3(0, 90, 0);
    private Vector3 shootVertical = new Vector3(90, 0, 0);

    // La función se encarga instanciar el prefab del proyectil en la posición
    // del Player donde la rotación depende del valor que le pasemos por parámetro.
    public void SpawnProjectile(Quaternion rotation)
    {
        Instantiate(projectilePrefab, transform.position, rotation);
    }


    // Update is called once per frame
    void Update()
    {

        // Pulsar tecla izquierda
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Valor de Quaternion.Euler
            rotation = Quaternion.Euler(-shootHorizontal);

            // Llama al input "rotation"
            SpawnProjectile(rotation);
        }

        // Si pulsas la tecla flecha derecha
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Valor de Quaternion.Euler
            rotation = Quaternion.Euler(shootHorizontal);

            // Llama al input "rotation"
            SpawnProjectile(rotation);
        }


        // Pulsar tecla de arriba
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Valor del Quaternion.Euler
            rotation = Quaternion.Euler(-shootVertical);

            // Llama al input "rotation"
            SpawnProjectile(rotation);
        }

        // Pulsar tecla de abajo
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Valor de Quaternion.Euler
            rotation = Quaternion.Euler(shootVertical);

            // Llama al input "rotation"
            SpawnProjectile(rotation);
        }
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float xRange = 30f;
    public GameObject projectileObject;
    public float horizontalInput;
    void Update()
    {
        //Передвижение по горизонтальной осм
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        //Игровоя зона
        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        else if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        //Заспавнить снаряд
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileObject, transform.position, projectileObject.transform.rotation);
        }
    }
}

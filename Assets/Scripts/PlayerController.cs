using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public Vector2 areaX = new Vector2(-23f, 23f);
    public Vector2 areaZ = new Vector2(-3f, 23f);
    public GameObject projectileObject;
    public float horizontalInput;   
    public float verticalInput;
    void Update()
    {
        Movement();
        ToThrow();
    }
    
    void Movement()
    {
        //Передвижение по горизонтальной осм
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput * speed * Time.deltaTime);
        transform.Translate(movement);

        //Игровоя зона
        float clampX = Mathf.Clamp(transform.position.x, areaX.x, areaX.y);
        float clampZ = Mathf.Clamp(transform.position.z, areaZ.x, areaZ.y);

        transform.position = new Vector3(clampX, transform.position.y, clampZ);
    }
    void ToThrow()
    {
        //Заспавнить снаряд
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileObject, transform.position, projectileObject.transform.rotation);
        }
    }
}

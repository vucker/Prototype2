using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public Vector2 areaX = new Vector2(-23f, 23f);
    public Vector2 areaY = new Vector2(-3f, 23f);
    public GameObject projectileObject;
    public float horizontalInput;   
    public float verticalInput;
    void Update()
    {
        //Передвижение по горизонтальной осм
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        //Игровоя зона
        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);
        


        ToThrow();
        
    }
    void ToThrow()
    {
        //Заспавнить снаряд
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileObject, transform.position, projectileObject.transform.rotation);
        }
    }
    void Movement()
    {

    }
}

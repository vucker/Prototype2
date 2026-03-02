using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager gameManager; 

    public float speed = 10f;

    public GameObject projectileObject;
    public float horizontalInput;   
    public float verticalInput;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        if (gameManager == null)
        {
            Debug.Log($"{nameof(gameManager)} отсуствует");
            return;
        }
    }
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
        float clampX = Mathf.Clamp(transform.position.x, gameManager.areaX.x, gameManager.areaX.y);
        float clampZ = Mathf.Clamp(transform.position.z, gameManager.areaZ.x, gameManager.areaZ.y);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 5f;
    private float downBound = -13f;

    void Update()
    {
        //условие для уничтожения снарядов
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //условие для уничтожения животных и поражения
        else if (transform.position.z < downBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}

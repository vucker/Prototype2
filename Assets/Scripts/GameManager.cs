using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector2 areaX = new Vector2(-23f, 23f);
    public Vector2 areaZ = new Vector2(-3f, 23f);
    public Color gizmosColor = Color.green;
    void Update()
    {
        

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = gizmosColor;
        Vector3 centerVector = new Vector3(
            (areaX.y + areaX.x) / 2,
            0,
            (areaZ.y + areaZ.x) / 2);
        Vector3 sizeVector = new Vector3(
            areaX.y - areaX.x,
            0,
            areaZ.y - areaZ.x);
        Gizmos.DrawWireCube(centerVector, sizeVector);
    }
}

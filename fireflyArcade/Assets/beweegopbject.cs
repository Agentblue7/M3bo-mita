using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beweegopbject : MonoBehaviour
{
    public float speed = 3f;
    public Vector3 areaSize = new Vector3(10f, 0f, 10f);
    private Vector3 targetPosition;

    void Start()
    {

        SetRandomTargetPosition();
    }

    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            SetRandomTargetPosition();
        }
    }

    void SetRandomTargetPosition()
    {

        float randomX = Random.Range(-areaSize.x / 2, areaSize.x / 2);
        float randomZ = Random.Range(-areaSize.z / 2, areaSize.z / 2);
        targetPosition = new Vector3(randomX, transform.position.y, randomZ);
    }
}
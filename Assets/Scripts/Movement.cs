using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    public float startPosition;
    public float endPosition;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x - movementSpeed * Time.deltaTime, transform.position.y);
        if (transform.position.x <= endPosition)
        {
            if (gameObject.tag == "Cactus")
            {
                Destroy(gameObject);
            }
            else
            {
                transform.position = new Vector2(startPosition, transform.position.y);
            }
        }
    }
}

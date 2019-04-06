using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 finalPos;
    public float xIncrement;
    public float speed;
    
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D)&& transform.position.x<4)
        {
            finalPos = new Vector2(transform.position.x+ xIncrement, transform.position.y);
        }
        if (Input.GetKeyDown(KeyCode.A)&&transform.position.x>-4)
        {
            finalPos = new Vector2(transform.position.x - xIncrement, transform.position.y);
        }
        transform.position = Vector2.MoveTowards(transform.position, finalPos, speed * Time.deltaTime);

    }
}

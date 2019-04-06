using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private Vector2 finalPos;
    public float xIncrement;
    public float speed;
    public Animator camAnim;

    public int health=3;
    
    void Start()
    {
    }

    void Update()
    {
        if (health==0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.D)&& transform.position.x<4)
        {
            finalPos = new Vector2(transform.position.x+ xIncrement, transform.position.y);
            camAnim.SetTrigger("Shake");
        }
        else if(Input.GetKeyDown(KeyCode.A)&&transform.position.x>-4)
        {
            finalPos = new Vector2(transform.position.x - xIncrement, transform.position.y);
            camAnim.SetTrigger("Shake");
        }
        
        transform.position = Vector2.MoveTowards(transform.position, finalPos, speed * Time.deltaTime);

    }
}

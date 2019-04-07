using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    private Vector2 finalPos;
    public float xIncrement;
    public float speed;
    public Animator camAnim;
    public TextMeshProUGUI healthDisplay;
    public int health=3;
    public GameObject gameOver;

    void Update()
    {
        healthDisplay.text = health.ToString();
        if (health==0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
            Time.timeScale = 0f;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        MoveRight();
        MoveLeft();
        transform.position = Vector2.MoveTowards(transform.position, finalPos, speed * Time.deltaTime);

    }

    public void MoveRight()
    {
       if (Input.GetKeyDown(KeyCode.D)&& transform.position.x<4)
        
            finalPos = new Vector2(transform.position.x+ xIncrement, transform.position.y);
            camAnim.SetTrigger("Shake");


    }

    public void MoveLeft()
    {
        if(Input.GetKeyDown(KeyCode.A)&&transform.position.x>-4)
            finalPos = new Vector2(transform.position.x - xIncrement, transform.position.y);
            camAnim.SetTrigger("Shake");
    }
}

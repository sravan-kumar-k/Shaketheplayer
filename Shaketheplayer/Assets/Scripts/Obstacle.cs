using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private int damage;
    public float speed;
    public GameObject effect;
    private Animator camAnim;
        
        private void Start()
    {
        damage = 1;
        camAnim = GameObject.FindGameObjectWithTag("Main Camera").GetComponent<Animator>();
    }
    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //camAnim.SetTrigger("Shake");

            Instantiate(effect, transform.position, transform.rotation);

            collision.GetComponent<Player>().health -= damage;
            Debug.Log(collision.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
}

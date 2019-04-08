using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private int damage=1;
    public float speed;
    public GameObject effect;

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, transform.rotation);

            collision.GetComponent<Player>().health -= damage;
            Debug.Log(collision.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
}

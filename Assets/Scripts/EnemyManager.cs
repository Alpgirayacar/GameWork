using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float health;
    public float damage;
    bool colliderBusy = false;

    void Start()
    {
        // Initialization code can be added here if needed
    }

    void Update()
    {
        // Update code can be added here if needed
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !colliderBusy)
        {
            colliderBusy = true;
            collision.GetComponent<PlayerManager>().GetDamage(damage);
        }
    }

    // Uncomment this block if needed
    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    // Code to be executed while the collider is staying in the trigger area
    //}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            colliderBusy = false;
        }
    }
}

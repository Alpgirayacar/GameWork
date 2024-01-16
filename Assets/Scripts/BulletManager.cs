using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public float bulletDamage, lifeTime;

    void Start()
    {
        Destroy(gameObject, lifeTime);  // Corrected the variable name to 'lifeTime'
    }

    // Update is called once per frame
    void Update()
    {
        // Code for updating the bullet if needed
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D playerRB; // Doðru yazým: "Rigidbody2D"
    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>(); // "Rigidbody2D" doðru yazým
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y); // Parantezlerin düzenlenmesi
    }

    void FixedUpdate()
    {
        // FixedUpdate içinde herhangi bir þey yapmýyorsanýz, bu metodun kaldýrýlabilir.
    }

    void HorizontalMove()
    {
        // Bu metodun içinde henüz bir þey yapýlmamýþ, gereksiz gibi görünüyor.
    }
}

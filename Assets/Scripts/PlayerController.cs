using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D playerRB; // Do�ru yaz�m: "Rigidbody2D"
    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>(); // "Rigidbody2D" do�ru yaz�m
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y); // Parantezlerin d�zenlenmesi
    }

    void FixedUpdate()
    {
        // FixedUpdate i�inde herhangi bir �ey yapm�yorsan�z, bu metodun kald�r�labilir.
    }

    void HorizontalMove()
    {
        // Bu metodun i�inde hen�z bir �ey yap�lmam��, gereksiz gibi g�r�n�yor.
    }
}

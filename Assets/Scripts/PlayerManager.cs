using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update

    public float helth,bulletSpeed;
    bool dead = false;
    Transform muzzle;
    public Transform bullet,floatingText;



    void Start()
    {
        muzzle = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ShootBullet();
        }
        
    }

    public void GetDamage(float damage)
    {
        Instantiate(floatingText,transform.position , Quaternion.identity).GetComponent<TextMesh>().text = damage.ToString();
        if((helth - damage) >=0 )
        {
            helth -= damage;
        }
        else
        {
            helth = 0;
        }
        AmIDead();  

    }

    void AmIDead ()
    {
        if(helth <= 0)
        {
            dead = true;
        }
    }

   public void ShootBullet()
    {
        Transform tempBullet; 
       tempBullet =  Instantiate(bullet,muzzle.position,Quaternion.identity);
        tempBullet.GetComponent<Rigidbody2D>().AddForce(muzzle.forward * bulletSpeed);

    }
}

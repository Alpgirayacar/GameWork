using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update

    public float helth,bulletSpeed;
    bool dead = false;
    Transform muzzle;
    public Transform bullet,floatingText;
    bool mouseIsNotOverUI;

    public Slider slider;


    void Start()
    {
        muzzle = transform.GetChild(1);

        slider.maxValue = helth;
        slider.value = helth;
    }

    // Update is called once per frame
    void Update()
    {
        mouseIsNotOverUI = EventSystem.current.currentSelectedGameObject == null;

        if (Input.GetMouseButtonDown(0) && mouseIsNotOverUI  )
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
        slider.value = helth;
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
        DataManager.Instance.ShotBullet++;

    }
}

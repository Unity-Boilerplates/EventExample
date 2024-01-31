using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
   [SerializeField] int damage = 10;

    void OnCollisionEnter(Collision collision){
         if(collision.gameObject.tag == "Player"){
              collision.gameObject.GetComponent<PlayerHealth>().takeDamage(damage);
         }
        Destroy(gameObject);

    }
}

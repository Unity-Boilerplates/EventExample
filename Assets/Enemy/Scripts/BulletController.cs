using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
   [SerializeField] int damage = 10;
   //[SerializeField] GameEventObject playerDamageChannel;
   [SerializeField] GameEventInt playerDamageChannel;

    void OnCollisionEnter(Collision collision){
         if(collision.gameObject.tag == "Player"){
              //playerDamageChannel.Raise(this, damage);
               playerDamageChannel.Raise(damage);
         }
        Destroy(gameObject);

    }
}

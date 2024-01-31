using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
   [SerializeField] int damage = 10;
   [SerializeField] GameEventWithData playerDamageChannel;

    void OnCollisionEnter(Collision collision){
         if(collision.gameObject.tag == "Player"){
              playerDamageChannel.Raise(this, damage);
         }
        Destroy(gameObject);

    }
}

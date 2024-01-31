using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageText : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] TMP_Text damageText;
   
    public void popUp(string damageToShow){
        damageText.text = damageToShow;
        Destroy(gameObject, 1);
        
    }




}

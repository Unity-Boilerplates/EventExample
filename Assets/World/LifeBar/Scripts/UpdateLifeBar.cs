using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateLifeBar : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Slider lifeSlider;

    [SerializeField] IntReference playerMaxHealth;
    [SerializeField] IntReference playerHealth;

    void setMaxHealth(){
        lifeSlider.maxValue = playerMaxHealth.Value;
    }

    void Start(){
        setMaxHealth();
    }

    public void Update(){
        lifeSlider.value = playerHealth.Value;
    }

    
}

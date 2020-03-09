using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthEvent : UnityEvent<float> { };

public class PlayerHealthDrainer : MonoBehaviour
{

    public float MaxHealth = 100f;
    private float ConstantDamage = 10f;
    private bool IsAlive = true;
    public HealthEvent healthEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Player" && IsAlive == true)
        {
            MaxHealth -= ConstantDamage * Time.deltaTime;
        }


        if (MaxHealth == 0)
        {
            IsAlive = false;
            Destroy(gameObject);
        }


        if (healthEvent != null)
            healthEvent.Invoke(MaxHealth);


    }
}

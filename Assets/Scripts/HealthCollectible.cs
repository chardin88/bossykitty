using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
 void OnTriggerEnter2D(Collider2D other)
    {
        Fox_Controller controller = other.GetComponent<Fox_Controller>();

        
        if(controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Fox_Controller controller = other.GetComponent<Fox_Controller>();

        if(controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}

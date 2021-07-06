using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{    
    private WeaponSwitch playerWeaponSwitch;

    private  void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {            
            playerWeaponSwitch = other.GetComponent<WeaponSwitch>();
            playerWeaponSwitch.EquipWeapon(transform);
            Destroy(this);
        }
    }
}

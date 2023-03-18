using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapon : MonoBehaviour, IWeapon 
{
    public int ammoCount { get; set; }
    public int magazineSize { get; set; }
    public float fireRate { get; set; }
    
    public void FireWeapon() {
        throw new System.NotImplementedException();
    }

    public void ReloadWeapon() {
        throw new System.NotImplementedException();
    }

}

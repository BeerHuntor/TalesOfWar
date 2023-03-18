using UnityEngine;

public interface IWeapon {
    public int ammoCount { get; set; }
    public int magazineSize { get; set; } 
    public float fireRate { get; set; }

    public void FireWeapon(); 

    public void ReloadWeapon();

}

using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    int currentWeapon = 0;
    void Start()
    {
        SetWeaponActive();
    }

    // Update is called once per frame
    void Update()
    {
     int previosWeapon = currentWeapon;  
     KeyInput(); 
     if(previosWeapon !=currentWeapon){
        SetWeaponActive();
     }
    }
    public void KeyInput () {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            currentWeapon = 0;
        }
         if(Input.GetKeyDown(KeyCode.Alpha2)){
            currentWeapon = 1;
        }

    }
    private void SetWeaponActive () {
        int weaponIndex = 0;
        foreach(Transform weapon in transform) {
            if(weaponIndex == currentWeapon){
                weapon.gameObject.SetActive(true);
            }else{
   weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }
}

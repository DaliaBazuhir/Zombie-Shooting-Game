using UnityEngine;

public class CollectAmmo : MonoBehaviour
{
    
    [SerializeField] Ammo ammoScript;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            ammoScript.IncreaseAmmoAmount(2);
            Destroy(gameObject);
        }
    }
}

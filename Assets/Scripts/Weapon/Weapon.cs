using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera fpCamera;
    [SerializeField] int weaponDamage = 10;
    [SerializeField] float weaponRange = 100f;    
    [SerializeField] ParticleSystem muzzleFlash;
    AudioSource audioSource;
    [SerializeField]Ammo ammoScript;
    private void Awake()
    {
      audioSource = GetComponent<AudioSource>();

          }

    void Start(){

    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
         if(ammoScript.GetCurrentAmmoAmount() > 0) {
                audioSource.Play();
                Shoot();
                MuzzleEffectFlash();
                ammoScript.DecreaseAmmoAmount();
       
         }
        }
    }
    void Shoot(){
     RaycastHit hit;
    Vector3 origin = fpCamera.transform.position;
    Vector3 direction = fpCamera.transform.forward * weaponRange;

    if (Physics.Raycast(origin, direction, out hit, weaponRange))
    {
        Debug.Log("Hit: " + hit.transform.name);
       
        // Draw the raycast in red if it hits something
        Debug.DrawRay(origin, direction, Color.red, 1f);
        EnemyHealth enemyHealth = hit.transform.GetComponent<EnemyHealth>();
        if(enemyHealth !=  null){
            enemyHealth.TakeDamage(weaponDamage);
        }
    }
    }
    void MuzzleEffectFlash(){
    muzzleFlash.Play();

    }
  
    
       void OnDrawGizmos()
    {
        if (fpCamera == null) return;

        Gizmos.color = Color.red;
        Vector3 origin = fpCamera.transform.position;
        Vector3 direction = fpCamera.transform.forward * weaponRange;

        Gizmos.DrawRay(origin, direction);
    }

}

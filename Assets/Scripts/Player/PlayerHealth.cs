using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int startingHealth = 100;
    int currentHealth;
    [SerializeField] Slider playerHealthbarSlider;
    void Awake()
    {
        currentHealth = startingHealth;
         playerHealthbarSlider.value = currentHealth;

    }
    void Update(){
        playerHealthbarSlider.value = currentHealth;
    }
   public  void TakeDamage(int damage){
        currentHealth -= damage;
        if(currentHealth <=0){
                         GetComponent<DeathHandler>().HandleDeath();

        }
    }
}

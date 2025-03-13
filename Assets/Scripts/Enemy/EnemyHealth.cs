using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int startingHealth = 100;
    int currentHealth;
    AudioSource audioSource;
    void Awake()
    {
        currentHealth = startingHealth;
        audioSource = GetComponent<AudioSource>();
    }
   public  void TakeDamage(int damage){
        currentHealth -= damage;
        if(currentHealth <=0){
            Die();
        }
    }

    void Die()
    {
        // Play death sound if audio source exists
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // Destroy game object after a delay if sound is played
        Destroy(gameObject, 0.5f);
    }
}

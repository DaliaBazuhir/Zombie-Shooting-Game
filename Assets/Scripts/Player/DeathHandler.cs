using UnityEngine;

public class DeathHandler : MonoBehaviour
{
     public Canvas gameOverCanvas;
    void Start()
    {
         gameOverCanvas.enabled = false;
    }

    public void HandleDeath(){
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible= true;
    }
}

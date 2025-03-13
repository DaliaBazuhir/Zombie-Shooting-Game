using UnityEngine;
 using UnityEngine.SceneManagement;
using System.Collections.Generic;
public class SceneLoader : MonoBehaviour
{
    public void RestartGame(){
    Time.timeScale =0;
    SceneManager.LoadScene(0);
   }
   public void QuitGame(){
   Application.Quit();
   }
}

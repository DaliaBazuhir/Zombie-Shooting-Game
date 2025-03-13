using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Ammo : MonoBehaviour
{
    [SerializeField] int ammoAmount = 10;
    [SerializeField] TMP_Text ammoTMPText;  // For TextMeshPro
    public void Start(){
        UpdateAmmoAmount();
    }
    public void IncreaseAmmoAmount (int extraAmmoAmount) {
        ammoAmount +=extraAmmoAmount;
          UpdateAmmoAmount();
    }
    public void DecreaseAmmoAmount () {
        ammoAmount-=1;
        UpdateAmmoAmount();
    }
    public int GetCurrentAmmoAmount () {
       return ammoAmount;
    }
    public void UpdateAmmoAmount(){
        ammoTMPText.text = "Ammo : "+ammoAmount;
    }


}

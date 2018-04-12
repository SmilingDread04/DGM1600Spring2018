using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //public float PowerLevel = 0.2;
    //publicImage HealthBar;
    //public PowerUp PowerUpTransfer;
    
    //void onTriggerEnter(Collider obj)
    //{
        //HealthBar.fillAmount += PowerLevel
        //if(HealthBar.fillAmount>0)
        //{
            //obj.GetComponent<MoveCharacter>().movePattern = PowerUpTransfer.MovePattern
        //}
    //}
    public Slider HealthBar;
    public float Health = 100;

    private float _currentHealth;

    void Start ()
    {
        _currentHealth = Health;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        HealthBar.value = _currentHealth;
    }
}
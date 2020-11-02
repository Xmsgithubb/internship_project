
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    
    
    public float starthealth = 100f;
    private float health;
    [Header ("unity stuff")]
    public Image HealthBar;
   public void Start()
    {
        health = starthealth;
    }
  
    public void takedmg(float amount)
    {
        health -= amount;
        HealthBar.fillAmount = health / starthealth;
        
        if (health <= 0f)
        {
            dead();

        }
    }

    void dead()
    {
        Destroy(gameObject);
    }

}

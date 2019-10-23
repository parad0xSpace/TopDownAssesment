using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool StPotionStatus = false;
    public static bool QuPotionStatus = false;
    public static bool InPotionStatus = false;
    public static float potionCooldown = 10.0f;
    public Text potionText;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "StReagent")
        {
            StPotionStatus = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "QuReagent")
        {
            QuPotionStatus = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "InReagent")
        {
            InPotionStatus = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "endLvl")
        {
            SceneManager.LoadScene("Lvl2");
        }
        if(collision.gameObject.tag == "endGame")
        {
            SceneManager.LoadScene("Win");
        }
    }

    void Update()
    {
        if(StPotionStatus == true)
        {
            StrengthPotion();
        }
        if(QuPotionStatus == true)
        {
            QuickPotion();
        }
        if(InPotionStatus == true)
        {
            InvinciblePotion();
        }
        if(StPotionStatus == true && QuPotionStatus == true || StPotionStatus == true && InPotionStatus == true || 
           QuPotionStatus == true && InPotionStatus == true)
        {
            Overload();
        }
    }

    void StrengthPotion()
    {
        potionCooldown -= Time.deltaTime;
        if (potionCooldown > 9 && potionCooldown <= 10)
        {
            potionText.text = "Strength Potion: 10";
        }
        if (potionCooldown > 8 && potionCooldown <= 9)
        {
            potionText.text = "Strength Potion: 9";
        }
        if (potionCooldown > 7 && potionCooldown <= 8)
        {
            potionText.text = "Strength Potion: 8";
        }
        if (potionCooldown > 6 && potionCooldown <= 7)
        {
            potionText.text = "Strength Potion: 7";
        }
        if (potionCooldown > 5 && potionCooldown <= 6)
        {
            potionText.text = "Strength Potion: 6";
        }
        if (potionCooldown > 4 && potionCooldown <= 5)
        {
            potionText.text = "Strength Potion: 5";
        }
        if (potionCooldown > 3 && potionCooldown <= 4)
        {
            potionText.text = "Strength Potion: 4";
        }
        if (potionCooldown > 2 && potionCooldown <= 3)
        {
            potionText.text = "Strength Potion: 3";
        }
        if (potionCooldown > 1 && potionCooldown <= 2)
        {
            potionText.text = "Strength Potion: 2";
        }
        if (potionCooldown > 0 && potionCooldown <= 1)
        {
            potionText.text = "Strength Potion: 1";
        }
        if (potionCooldown <= 0)
        {
            potionText.text = "Potion: None";
            StPotionStatus = false;
            potionCooldown = 10.0f;
        }
    }

    void QuickPotion()
    {
        potionCooldown -= Time.deltaTime;
        if (potionCooldown > 9 && potionCooldown <= 10)
        {
            potionText.text = "Quick Potion: 10";
        }
        if (potionCooldown > 8 && potionCooldown <= 9)
        {
            potionText.text = "Quick Potion: 9";
        }
        if (potionCooldown > 7 && potionCooldown <= 8)
        {
            potionText.text = "Quick Potion: 8";
        }
        if (potionCooldown > 6 && potionCooldown <= 7)
        {
            potionText.text = "Quick Potion: 7";
        }
        if (potionCooldown > 5 && potionCooldown <= 6)
        {
            potionText.text = "Quick Potion: 6";
        }
        if (potionCooldown > 4 && potionCooldown <= 5)
        {
            potionText.text = "Quick Potion: 5";
        }
        if (potionCooldown > 3 && potionCooldown <= 4)
        {
            potionText.text = "Quick Potion: 4";
        }
        if (potionCooldown > 2 && potionCooldown <= 3)
        {
            potionText.text = "Quick Potion: 3";
        }
        if (potionCooldown > 1 && potionCooldown <= 2)
        {
            potionText.text = "Quick Potion: 2";
        }
        if (potionCooldown > 0 && potionCooldown <= 1)
        {
            potionText.text = "Quick Potion: 1";
        }
        if (potionCooldown <= 0)
        {
            potionText.text = "Potion: None";
            QuPotionStatus = false;
            potionCooldown = 10.0f;
        }
    }

    void InvinciblePotion()
    {
        potionCooldown -= Time.deltaTime;
        if (potionCooldown > 9 && potionCooldown <= 10)
        {
            potionText.text = "Invincible Potion: 10";
        }
        if (potionCooldown > 8 && potionCooldown <= 9)
        {
            potionText.text = "Invincible Potion: 9";
        }
        if (potionCooldown > 7 && potionCooldown <= 8)
        {
            potionText.text = "Invincible Potion: 8";
        }
        if (potionCooldown > 6 && potionCooldown <= 7)
        {
            potionText.text = "Invincible Potion: 7";
        }
        if (potionCooldown > 5 && potionCooldown <= 6)
        {
            potionText.text = "Invincible Potion: 6";
        }
        if (potionCooldown > 4 && potionCooldown <= 5)
        {
            potionText.text = "Invincible Potion: 5";
        }
        if (potionCooldown > 3 && potionCooldown <= 4)
        {
            potionText.text = "Invincible Potion: 4";
        }
        if (potionCooldown > 2 && potionCooldown <= 3)
        {
            potionText.text = "Invincible Potion: 3";
        }
        if (potionCooldown > 1 && potionCooldown <= 2)
        {
            potionText.text = "Invincible Potion: 2";
        }
        if (potionCooldown > 0 && potionCooldown <= 1)
        {
            potionText.text = "Invincible Potion: 1";
        }
        if (potionCooldown <= 0)
        {
            potionText.text = "Potion: None";
            InPotionStatus = false;
            potionCooldown = 10.0f;
        }
    }

    void Overload()
    {
        SceneManager.LoadScene("Lose");
    }
}

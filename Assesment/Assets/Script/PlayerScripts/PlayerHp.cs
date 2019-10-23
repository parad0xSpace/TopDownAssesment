using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    public int hp = 10;
    public Text hpText;

    void Start()
    {
        hpText.text = "HP: " + hp;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy" && PotionScript.InPotionStatus == false)
        {
            hp--;
            hpText.text = "HP: " + hp;
            //same as hp -= or hp -1
            if(hp < 1)
            {
                //die
                SceneManager.LoadScene("Lose");
                //SceneManager.LoadScene("HahaLoser");
            }
        }
    }
}

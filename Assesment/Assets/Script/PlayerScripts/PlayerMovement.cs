using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float startSpeed;

    // Start is called before the first frame update
    void Start()
    {
        startSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (PotionScript.QuPotionStatus == true)
        {
            moveSpeed = 2 * startSpeed;
        }
        else
        {
            moveSpeed = startSpeed;
        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(x, y);
        GetComponent<Rigidbody2D>().velocity = velocity * moveSpeed;
    }
}

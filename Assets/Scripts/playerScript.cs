using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float speed;
    public Animator anim;
    private bool isJump;
    private void Start()
    {
        
    }
    void Update()
    {
        movement();
    }

    void movement()
    {
        isJump = false;
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x < 25)
        {
            transform.position = new Vector3(transform.position.x + 25f, transform.position.y, transform.position.z);

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x > -25)
        {
            transform.position = new Vector3(transform.position.x -25f, transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && !isJump)
        {
            isJump = true;
            transform.Translate(Vector3.up * 5000f * Time.deltaTime);
            
            
            anim.SetTrigger("jump");
        }
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);

        
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateRun : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animRun;
    SpriteRenderer sR;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animRun = GetComponent<Animator>();
        sR = GetComponent<SpriteRenderer>();
        speed = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = new Quaternion(0,0,0,0);
        rigid2D.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);

        if (Input.GetAxis("Horizontal") != 0)
        {
            animRun.SetBool("isRunning", true);
            if (Input.GetAxis("Horizontal") != 0)
            {
                sR.flipX = true;
            }
            else
            {
                sR.flipX = false;
            }
        }
        else 
        {
            animRun.SetBool("isRunning", false);
        }
    }
}

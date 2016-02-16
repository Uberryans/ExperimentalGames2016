using UnityEngine;
using System;
using System.Collections;

/*
 * 2D Character Controller for Player. Will likely eventually become a subclass of a Controller class that will also include enemies with similar behavior.
 */

public class EnemyController : MonoBehaviour
{

    //public float maxSpeed = 3; //Max speed value allowed

    Transform target;
    Transform enemyTransform;
    GameObject player;
    public float speed = 3f;
    public float rotationSpeed = 3f;
    bool reset = false;

    private float move;

    bool right = true; //What Direction Is Player Facing


    bool attack = false;


    void Start()
    {
        enemyTransform = this.GetComponent<Transform>();
        player = GameObject.Find("Character Rig");
    }

    void Update()
    {
        target = GameObject.FindWithTag("Player").transform;
        Vector2 targetHeading = target.position - transform.position;
        Vector2 targetDirection = targetHeading.normalized;

        move = target.position.x - transform.position.x;

        //rotate to look at the player

        if (move > 0 && !right)
        {
            Flip();
        }
        else if (move < 0 && right)
        {
            Flip();
        }


        //move towards the player
        GetComponent<Rigidbody2D>().velocity = new Vector2 (speed * targetDirection.x, GetComponent<Rigidbody2D>().velocity.y);
        //GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y); //move object
        //enemyTransform.position += enemyTransform.forward * speed * Time.deltaTime;


    }


    /*
 * Flip switches the facing direction of the character. 
 */
    void Flip()
    {
        right = !right;
        Vector3 scale = transform.localScale;
        scale.x = scale.x * -1;
        transform.localScale = scale;
        /*if (right)
        {
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        right = !right;*/
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Physics2D.IgnoreCollision(col.gameObject.GetComponent<Collider2D>(), this.gameObject.GetComponent<Collider2D>());
        }
        if (col.gameObject.tag == "Player")
        {
            if (!reset)
            {
                if(this.name == "Cyborg Rig")
                {
                    player.GetComponent<PlayerHealth>().playerHealth = player.GetComponent<PlayerHealth>().playerHealth - 2;
                    reset = true;
                    StartCoroutine(resetWait());
                }
                if (this.name == "Dog_Rig")
                {
                    player.GetComponent<PlayerHealth>().playerHealth = player.GetComponent<PlayerHealth>().playerHealth - 1;
                    reset = true;
                    StartCoroutine(resetWait());
                }
                if (this.name == "Mech_Rig")
                {
                    player.GetComponent<PlayerHealth>().playerHealth = player.GetComponent<PlayerHealth>().playerHealth - 3;
                    reset = true;
                    StartCoroutine(resetWait());
                }
                if (this.name == "Walrus_Rig")
                {
                    player.GetComponent<PlayerHealth>().playerHealth = player.GetComponent<PlayerHealth>().playerHealth - 5;
                    reset = true;
                    StartCoroutine(resetWait());
                }

                player.GetComponent<PlayerHealth>().playerHealth--;
                reset = true;
                StartCoroutine(resetWait());
            }
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            if (!reset)
            {
                player.GetComponent<PlayerHealth>().playerHealth--;
                reset = true;
                StartCoroutine(resetWait());
            }
        }
    }

    IEnumerator resetWait()
    {
        yield return new WaitForSeconds(1f);
        reset = false;
    }
}

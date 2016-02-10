using UnityEngine;
using System.Collections;

/*
 * 2D Character Controller for Player. Will likely eventually become a subclass of a Controller class that will also include enemies with similar behavior.
 */

public class EnemyController : MonoBehaviour
{

    //public float maxSpeed = 3; //Max speed value allowed

    Transform target;
    Transform enemyTransform;
    public float speed = 3f;
    public float rotationSpeed = 3f;

    private float move;

    bool right = true; //What Direction Is Player Facing


    bool attack = false;


    void Start()
    {
        enemyTransform = this.GetComponent<Transform>();
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
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y); //move object
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
        speed = speed * -1;
    }

}

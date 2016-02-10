using UnityEngine;
using System.Collections;



public class CharacterCont : MonoBehaviour
{

    public float maxSpeed = 5; //Max speed value allowed
    //public Animator anim; //Will be implemented once we have animations

    bool right = true; //What Direction Is Player Facing

    public Transform groundCheck; //Transform to Check for Ground
    public LayerMask groundType; //Define What Is Ground
    bool grounded = false; //Is player on ground
    float groundRadius = 0.2f; //Groundcheck radius

    bool jump = false; //Is player jumping
    public float jumpForce = 100f; //Max amount of jump force given
    public float runForce = 200f;

    bool roll = false; //Is player rolling
    public float rollForce = 5000f; //Roll force given

    int punch = 0; //Is player punching.
                   //0 = Idle/Not Punching
                   //1 = Default Punch

    void Start()
    {
       // anim = gameObject.GetComponent<Animator>(); //Will be implemented once we have animations
    }

    void Update()
    {

        if (Input.GetButtonDown("Jump") && GetComponent<Rigidbody2D>().velocity.y == 0f)
        { //Jump
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
            jump = true;
        }

        float move = Input.GetAxis("Horizontal"); //Get horizontal input

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y); //Take input and move object

        if (move > 0 && !right)
        {
            Flip();
        }
        else if (move < 0 && right)
        {
            Flip();
        }

        if (Input.GetButtonDown("Attack") && grounded)
        { //no attack yet
            if (right)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(rollForce, 0f));
            }
            else
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-rollForce, 0f));
            }
            roll = true;
        }




    }

    void Flip()
    {
        right = !right;
        Vector3 scale = transform.localScale;
        scale.x = scale.x * -1;
        transform.localScale = scale;
    }
}

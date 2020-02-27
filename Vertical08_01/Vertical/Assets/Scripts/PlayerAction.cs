using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    [SerializeField]
    Player player;

    Rigidbody rb;

    //------------------//
    Vector3 directionJump;
    //------------------//

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        directionJump = new Vector3(0f, 2f, 0f);
    }

    void Update()
    {

    }
    void FixedUpdate()
    {
        movement();
    }

    void movement()
    {
            //rb.velocity=transform.forward*walkspeed;   //multiplica la velocidad por el eje del personaje (no el del mundo)
        //Front
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * player.walkSpeed); //descomponemos el vector forward para poder modificar el valor de y para que caiga el personaje
            //anim.GetComponent<Animator>().SetBool("Walk", true);
        }
        ////Back
        //if (Input.GetKey(KeyCode.S))
        //{
        //    rb.velocity = new Vector3(transform.forward.x, rb.velocity.y, transform.forward.z * player.runSpeed); //descomponemos el vector forward para poder modificar el valor de y para que caiga el personaje
        //    //anim.GetComponent<Animator>().SetBool("Walk", true);
        //}
        ////Right
        //if (Input.GetKey(KeyCode.D))
        //{
        //    rb.velocity = new Vector3(transform.forward.x * player.runSpeed, rb.velocity.y, transform.forward.z);
        //     //descomponemos el vector forward para poder modificar el valor de y para que caiga el personaje
        //    //anim.GetComponent<Animator>().SetBool("Walk", true);
        //}
        ////Left
        //if (Input.GetKey(KeyCode.A))
        //{
        //    rb.velocity = new Vector3(transform.forward.x * -player.runSpeed, rb.velocity.y, transform.forward.z);
        //     //descomponemos el vector forward para poder modificar el valor de y para que caiga el personaje
        //    //anim.GetComponent<Animator>().SetBool("Walk", true);
        //}
    }
}

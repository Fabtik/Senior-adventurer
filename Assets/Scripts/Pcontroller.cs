using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pcontroller : MonoBehaviour
{
    float Ver, Hor, Jump;

    bool isGround;

    public float Speed = 10f, JumpSpeed = 200f, TurnSpeed = 200f;

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGround = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGround = false;
        }
    }

    void Update()
    {

        if (isGround)
        {

            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up, -TurnSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
            }
            Ver = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
           // Hor = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
            Jump = Input.GetAxis("Jump") * Time.deltaTime * JumpSpeed;
            GetComponent<Rigidbody>().AddForce(transform.up * Jump, ForceMode.Impulse);  
        }
        transform.Translate(new Vector3(0, 0, Ver));
        //transform.Translate(new Vector3(Hor, 0, Ver));
    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pcontroller : MonoBehaviour
{
    float Ver;
    public bool isGround, isGroundBorder;
    public float Speed = 1f, JumpSpeed = 200f, TurnSpeed = 200f;
    public HelthbarController helthbar;
    public StaminaController stamina;
   

    void OnCollisionEnter(Collision collision)
   {
        if(collision.gameObject.tag == "Enemy")
        {
            if (helthbar)
            {
                helthbar.OnTakeDamage(10);
                var position =  transform.position - collision.gameObject.transform.position;
                // GetComponent<Rigidbody>().AddForce(new Vector3(position.x, Mathf.Abs(position.y), position.z) * 10f, ForceMode.Impulse);
                GetComponent<Rigidbody>().AddForce(new Vector3(position.x, 0.5f, position.z) * 10f, ForceMode.Impulse);

            }
        }
        if (collision.gameObject.tag == "Trap")
        {
            if (helthbar)
            {
                helthbar.OnTakeDamage(1000);
                //var position = transform.position - collision.gameObject.transform.position;
                //// GetComponent<Rigidbody>().AddForce(new Vector3(position.x, Mathf.Abs(position.y), position.z) * 10f, ForceMode.Impulse);
                //GetComponent<Rigidbody>().AddForce(new Vector3(position.x, 0.5f, position.z) * 10f, ForceMode.Impulse);

            }
        }
        
        if (collision.gameObject.tag == "Mushroom")
        {
            if (helthbar)
            {
                
                //var position = transform.position - collision.gameObject.transform.position;
                //var position = collision.gameObject.transform.position - transform.position;
                // GetComponent<Rigidbody>().AddForce(new Vector3(position.x, Mathf.Abs(position.y), position.z) * 10f, ForceMode.Impulse);
                // GetComponent<Rigidbody>().AddForce(new Vector3(position.x, 0.5f, position.z) * 10f, ForceMode.Impulse);
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 0.8f, 0) * 10f, ForceMode.Impulse);

            }
        }
    }
    

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGround = true;
        }
        //if (other.gameObject.tag == "ground border")
        //{
        //    isGroundBorder = true;
        //}
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGround = false;
        }
        if (other.gameObject.tag == "ground border")
        {
            isGroundBorder = false;
        }
    }

    void FixedUpdate()
    {
        if(helthbar.HP() > 0) { 
        if (isGround /*&& !isGroundBorder*/)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up, -TurnSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Space) && stamina.ST() >= 1)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0) * 7f, ForceMode.VelocityChange);
                stamina.staminaSpending(1);
            }
            Ver = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
 
        }
        /*else if (isGround && isGroundBorder)
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
            
        }
        */
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up, -TurnSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
            }
            Ver = Input.GetAxis("Vertical") * Time.deltaTime * Speed;

            transform.Translate(new Vector3(0, 0, Ver));
        }
    }

}
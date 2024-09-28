using UnityEngine;
public class player_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce= 2000f;
    public float sideways= 500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce* Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideways*Time.deltaTime, 0 ,0 );
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideways*Time.deltaTime,0,0);
        }
    }    

}
using UnityEngine;

public class physics : MonoBehaviour
{
    public  Rigidbody rb;

    public float forwardforce = 1000f;
    public float sidewaysforce = 600f;
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardforce*Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
         if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

         if(rb.position.y < -1f)
        {
           FindAnyObjectByType<gamemanager>().Gameover();
        }

    }
}

using UnityEngine;

public class playercollision : MonoBehaviour
{

    public physics movement;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="obstacle")
        {
          movement.enabled = false;
        FindAnyObjectByType<gamemanager>().Gameover();
        }

    }
}

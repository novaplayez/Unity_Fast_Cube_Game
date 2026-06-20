using UnityEngine;

public class testScript : MonoBehaviour
{
    // This variable controls the speed of our cube
    public float speed = 5f;

    void Update()
    {
        // 1. Get input from Arrow keys or WASD (returns a value between -1 and 1)
        // float horizontalInput = Input.GetAxis("Horizontal");
        // float verticalInput = Input.GetAxis("Vertical");

        // // 2. Create a movement vector based on that input (X, Y, Z axis)
        // Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput);


        // // 3. Move the object! 
        // // transform.Translate moves the object's position relative to its current frame
        // transform.Translate(direction * speed * Time.deltaTime);
    }
}





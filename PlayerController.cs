using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // This variable can be set to adjust the movement speed of the player
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Get input from the horizontal and vertical axes (WASD or arrow keys by default)
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Create a movement vector based on the input and the move speed
        Vector3 movement = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;

        // Apply the movement to the player's position
        transform.position += movement;
    }
}

using UnityEngine;

public class NPCChaseAI : MonoBehaviour
{
    // Reference to the player's transform component
    public Transform playerTransform;

    // The distance at which the NPC should start to chase the player
    public float chaseDistance = 15f;

    // The speed at which the NPC should move towards the player
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Calculate the distance between the NPC and the player
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        // Check if the player is within the chase distance
        if (distanceToPlayer <= chaseDistance)
        {
            // Move the NPC towards the player's current position
            Vector3 directionToPlayer = (playerTransform.position - transform.position).normalized;
            Vector3 movement = directionToPlayer * moveSpeed * Time.deltaTime;

            // Apply the movement to the NPC's position
            transform.position += movement;
        }
    }
}

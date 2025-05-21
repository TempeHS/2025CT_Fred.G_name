using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 5f; // Adjust this to control how fast the object moves

    private void Update()
    {
        // Check if a target is assigned.  If not, don't move.
        if (target == null) {
            return;
        }

        // Use MoveTowards to smoothly move the object towards the target
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Optional: Stop moving when close to the target
        if (Vector3.Distance(transform.position, target.position) < 0.1f) {
            // You can add logic here, like stopping the movement or triggering an action
            Debug.Log("Reached target!");
            // Stop moving by returning
            return;
        }
    }
}
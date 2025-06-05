using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 5f;
    private bool reachedtarget = false;
    private int score = 0;

    private void Update()
    {
        // Check if a target is assigned.  If not, don't move.
        if (target == null)
        {
            return;
        }

        // Use MoveTowards to smoothly move the object towards the target
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);


        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            return;
        }
        if reachedtarget = true;
        {
            Destroy(gameObject);
            score++;
            Debug.Log("Score is: " + score);
        }
    }
}
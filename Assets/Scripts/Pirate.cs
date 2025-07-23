using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 5f;
    private bool reachedtarget = false;
    public static int score = 0;

    private void Update()
    {  
        if (target == null)
        {
            return;
        } 
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);


        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            Destroy(gameObject);
            score-=2;
            Debug.Log("Score is: " + score);
            return;
        }
    }
}
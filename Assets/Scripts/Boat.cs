using UnityEngine;

public class Boat : MonoBehaviour
{
    public float speed = 2f;
    public Transform target; // Assign this in the Inspector

    private Vector2 direction;
    private Camera cam;
    private float camWidth, camHeight;

    private float hoverTime = 0f;
    private bool hovering = false;
    private float exitTimer = 0f;
    private bool exited = false;

    private static int BoatScore = 0;

    private SpriteRenderer sr;
    private bool movingToTarget = false; // Track if moving to target

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        direction = Random.insideUnitCircle.normalized;
        cam = Camera.main;
        camHeight = 2f * cam.orthographicSize;
        camWidth = camHeight * cam.aspect;
    }

    void Update()
    {
        if (movingToTarget && target != null)
        {
            // Move towards the target
            Vector3 targetPos = target.position;
            Vector3 moveDir = (targetPos - transform.position).normalized;
            transform.position += moveDir * speed * Time.deltaTime;

            // Optionally, stop when close to target
            if (Vector3.Distance(transform.position, targetPos) < 0.1f)
            {
                movingToTarget = false;
                // Optionally, do something when reached
            }
            return;
        }

        transform.Translate(direction * speed * Time.deltaTime);

        Vector3 pos = transform.position;

        if (pos.x <= -camWidth / 2 || pos.x >= camWidth / 2)
            direction.x *= -1;

        if (pos.y <= -camHeight / 2 || pos.y >= camHeight / 2)
            direction.y *= -1;

        // Track hover time
        if (hovering)
        {
            hoverTime += Time.deltaTime;
            if (hoverTime >= 3f)
            {
                movingToTarget = true; // Start moving to target
                // BoatScore++;
                // ObjectMovement.score += 5;
                // Debug.Log("Boat Score is: " + BoatScore);
                return;
            }
            exitTimer = 0f;
            exited = false;
        }
        else
        {
            if (!exited)
            {
                // Start the 1-second exit delay
                exited = true;
                exitTimer = 0f;
            }

            exitTimer += Time.deltaTime;

            if (exitTimer >= 2)
            {
                hoverTime = 0f;
            }
        }
        if (Vector3.Distance(transform.position, target.position) < 1f) // f is how close to the harbour when destoyed? too low can cause glitch
        //&& to if statemt, random boats with no hovertime can go to harbour but can keep this for luck.
        {
            Destroy(gameObject);
            ObjectMovement.score += 5;
            return;
        }
        if (hoverTime >= 2.99)
        {
            sr.color = Color.green;
        }
        else
        {
            sr.color = Color.white;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cursor"))
        {
            hovering = true; 
        }

        if (other.gameObject.tag == "rock")
        {
            Destroy(gameObject);
            ObjectMovement.score -= 2;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Cursor"))
            hovering = false;
    }
}
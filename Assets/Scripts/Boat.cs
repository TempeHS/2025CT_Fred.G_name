
using UnityEngine;

public class Boat : MonoBehaviour
{
    public float speed = 2f;

    private Vector2 direction;
    private Camera cam;
    private float camWidth, camHeight;

    private float hoverTime = 0f;
    private bool hovering = false;
    private float exitTimer = 0f;
    private bool exited = false;

    private static int BoatScore = 0;


    private SpriteRenderer sr;

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
                Destroy(gameObject);
                BoatScore++;
                ObjectMovement.score += 5;
                Debug.Log("Boat Score is: " + BoatScore);
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
        if (hoverTime >= 1)
        {
            sr.color = Color.green;
        }
        else
        {
            sr.color = Color.yellow;
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

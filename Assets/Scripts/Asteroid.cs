
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float speed = 2f;

    private Vector2 direction;
    private Camera cam;
    private float camWidth, camHeight;

    private float hoverTime = 0f;
    private bool hovering = false;

    void Start()
    {
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
                Destroy(gameObject);
        }
        else
        {
            hoverTime = 0f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cursor"))
            hovering = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Cursor"))
            hovering = false;
    }
}

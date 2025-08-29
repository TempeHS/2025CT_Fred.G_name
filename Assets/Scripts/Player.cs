using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public static int bombs = 0;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(x, y).normalized;

        transform.Translate(movement * speed * Time.deltaTime);
    }
        private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("rock") && bombs >= 1)
        {
            Destroy(other.gameObject);
            bombs -= 1;
        }
    }
}

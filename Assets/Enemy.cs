using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float blockSpeed = 2.0f;
    float speedInterval = 10.0f;
    float collisionTime = 0f;
    public bool collisionHappened = false;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0, 0);
    }

    private void Update()
    {
        if (Time.timeSinceLevelLoad > speedInterval)
        {
            blockSpeed += 1f;
            speedInterval += 10.0f;
        }

        if (transform.position.y < -7.0f)
            Destroy(gameObject);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, -blockSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        FindObjectOfType<GameManager>().EndGame();

    }
}
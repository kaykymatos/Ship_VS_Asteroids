using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Vector2 direction = new(0, 1);
    public float speed = 20;
    public Vector2 velocity;

    void Start()
    {
        Destroy(gameObject, 3);
    }


    void Update()
    {
        velocity = direction * speed;

    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Asteroids"))
        {
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos;
    }
}

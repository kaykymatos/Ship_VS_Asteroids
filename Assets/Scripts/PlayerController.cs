using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GunScript guns;
    private void Start()
    {
        guns = GetComponentInChildren<GunScript>();
    }
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
            guns.Shoot();

        Vector3 movimentaX = 10f * horizontal * Time.deltaTime * Vector3.right;
        Vector3 movimentaY = 10f * Time.deltaTime * vertical * Vector3.up;
        transform.Translate(movimentaX + movimentaY);

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Asteroids"))
        {
            Destroy(collider.gameObject);
        }
    }
}

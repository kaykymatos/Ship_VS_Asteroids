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


        transform.Translate(vertical * 10f * Vector3.up * Time.deltaTime + horizontal * 10f * Vector3.right * Time.deltaTime);

    }
}

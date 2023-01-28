using UnityEngine;

public class GunScript : MonoBehaviour
{
    public BulletScript bullet;

    public void Shoot()
    {
        Instantiate(bullet.gameObject, transform.position, Quaternion.identity);
    }
}

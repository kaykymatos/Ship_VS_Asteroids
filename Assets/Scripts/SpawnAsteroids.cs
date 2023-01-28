using UnityEngine;

public class SpawnAsteroids : MonoBehaviour
{
    public Transform[] asteroid;
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, 2f);
    }
    void Spawn()
    {
        Instantiate(asteroid[Random.Range(1, 5)], new Vector3(Random.Range(-22, 22), transform.position.y), Quaternion.identity);
    }
}

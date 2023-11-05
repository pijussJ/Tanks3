
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public GameObject toDestruct;
    public GameObject cube;
    private void Start()
    {
        Destroy(gameObject, 2f);
    }
    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Building")
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(cube, transform.position, transform.rotation);
            }
            Destroy(toDestruct);
        }
    }

}


using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public GameObject particle;
    public int particleCount;
    public GameObject explosionMark;

    public AudioSource explosionSound;

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
        Destroy(gameObject);
        if (collision.gameObject.tag == "Boom")
        {
            Destroy(collision.gameObject);
            for (int i = 0; i < particleCount; i++)
            {
                var offset = Random.insideUnitSphere;
                Instantiate(particle, transform.position + offset, transform.rotation);
                explosionSound.Play();
                explosionMark.SetActive(true);
                Instantiate(explosionMark, transform.position, transform.rotation);
            }
        }
        
    }
}

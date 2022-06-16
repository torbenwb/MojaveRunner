using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // control how fast the obstacle moves across the screen
    public float moveSpeed = 5.0f;
    // control how far the object should go before being destroyed offscreen.
    public float endRange = -12f;

    // add later
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * moveSpeed * Parallax.speed * Time.deltaTime;

        if (transform.position.x <= endRange){
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Health.TryDamageGameObject(other.gameObject, damage);
    }
}

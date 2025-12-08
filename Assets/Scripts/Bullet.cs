using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed = 10;

    void Start ()
    {
		GetComponent<Rigidbody2D>().linearVelocity = transform.up.normalized * speed;
    }
}
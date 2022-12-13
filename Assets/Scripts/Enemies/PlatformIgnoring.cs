using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class PlatformIgnoring : MonoBehaviour
{
    private EdgeCollider2D _enemyCollider;
    private BoxCollider2D _platformCollider;

    private void Awake()
    {
        _enemyCollider = GetComponent<EdgeCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Platform>(out Platform platform))
        {
            Physics2D.IgnoreCollision(_enemyCollider, platform.Collider);
        } 
    }
}
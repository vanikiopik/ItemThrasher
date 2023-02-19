using UnityEngine;

public class ExplosionForce : MonoBehaviour
{
    public static float explosionForce = 500f;
    public static float explosionRadius = 40f;

    private void OnMouseDown()
    {
        Debug.Log("asd");
        ApplyExplosionForce();
        GameObject.Destroy(gameObject);
    }
    public void ApplyExplosionForce()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, explosionRadius);

        foreach (Collider2D col in colliders)
        {
            Rigidbody2D rb = col.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 direction = rb.transform.position - transform.position;
                float distance = direction.magnitude;
                float falloff = 1f - Mathf.Clamp01(distance / explosionRadius);
                Vector2 force = direction.normalized * explosionForce * falloff;
                rb.AddForce(force);
            }
        }
    }
}
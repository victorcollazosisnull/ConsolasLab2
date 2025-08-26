using UnityEngine;

public class Bala : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            kills counter = FindAnyObjectByType<kills>();
            if (counter != null)
            {
                counter.AddKill();
            }

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

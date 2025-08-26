using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public Transform spawn;
    public GameObject balaPrefab;
    public float forceShoot = 20f;

    private bool isShooting = false;
    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isShooting = true;
        }
    }
    public void Update()
    {
        if (isShooting)
        {
            GameObject bala = Instantiate(balaPrefab, spawn.position, spawn.rotation);
            Rigidbody rb = bala.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(spawn.forward * forceShoot, ForceMode.VelocityChange);
            }
            Destroy(bala,5f);
            isShooting = false;
        }
    }
}

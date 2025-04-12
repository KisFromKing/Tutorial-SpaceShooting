using UnityEngine;

public class BulletFly : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10f;
    private Vector3 bulletDirection = Vector3.down;

    void Update()
    {
        HandleBulletFly();
    }

    private void HandleBulletFly()
    {
        transform.parent.Translate(bulletDirection * bulletSpeed * Time.deltaTime);
    }
}

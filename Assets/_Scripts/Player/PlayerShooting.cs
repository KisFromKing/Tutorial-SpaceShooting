using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefap;
    [SerializeField] private bool isShotting = false;

    void Start()
    {
        
    }

    void Update()
    {
        HandleShotting();
    }

    private void HandleShotting()
    {
        if (!isShotting)
        {
            return;
        }

        Instantiate(bulletPrefap,transform.parent.position,transform.parent.rotation);
    }
}

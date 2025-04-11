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
        
    }

    private void HandleShotting()
    {
        if (!isShotting)
        {
            return;
        }

        Instantiate(bulletPrefap);
    }
}

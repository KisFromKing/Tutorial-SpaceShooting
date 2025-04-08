using UnityEngine;

public class PlayerShipMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    private Vector3 mousePos = new();

    void Update()
    {
        GetMousePos();
        ResetZAxis();
        HandleMovement();
    }

    private void GetMousePos()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void ResetZAxis()
    {
        mousePos.z = 0;
    }

    private void HandleMovement()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.transform.position, mousePos,moveSpeed);
        transform.parent.position = newPos;
    }
}

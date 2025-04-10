using UnityEngine;

public class PlayerShipMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0.1f;
    private Vector3 targetPos = new();

    void Update()
    {
        GetTargetPos();
        ResetZAxis();
        LookAtTargetPos();
        HandleMovement();
    }

    private void LookAtTargetPos()
    {
        Vector3 diff = this.targetPos - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z + 90);
    }

    private void GetTargetPos()
    {
        targetPos = InputManager.Instance.MouseWorldPos;
    }

    private void ResetZAxis()
    {
        targetPos.z = 0;
    }   

    private void HandleMovement()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.transform.position, targetPos,moveSpeed);
        transform.parent.position = newPos;
    }
}

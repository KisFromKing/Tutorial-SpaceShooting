using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Vector3 mouseWorldPos = new();
    public Vector3 MouseWorldPos { get { return mouseWorldPos; } }

    private static InputManager instance;
    public static InputManager Instance {get { return instance; }}

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("There is another instant");
            return;
        }
        instance = this;
    }
    void Update()
    {
        GetMouseWorldPos();
    }

    private void GetMouseWorldPos()
    {
        mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}

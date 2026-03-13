using UnityEngine;
using UnityEngine.InputSystem;

public class EyeTracker : MonoBehaviour
{
    void Update()
    {
        if (Mouse.current == null || Camera.main == null) return;

        Vector2 mousePos = Mouse.current.position.ReadValue();
        float distance = Vector3.Distance(Camera.main.transform.position, transform.position);
        Vector3 targetPoint = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, distance));

        transform.LookAt(targetPoint);
    }
}
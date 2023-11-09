using UnityEngine;
using UnityEngine.VFX;

public class MouseFollow : MonoBehaviour
{
    public VisualEffect vfx;
    private Vector3 previousMousePosition;

    private void Start()
    {
        vfx = GetComponent<VisualEffect>();
        previousMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        worldPos.z = transform.position.z; // Maintain current z position

        vfx.SetVector3("MousePosition", worldPos);
        vfx.SetVector3("PreviousMousePosition", previousMousePosition);
        previousMousePosition = worldPos;
    }
}


using UnityEngine;
public class rotate : MonoBehaviour
{
    Vector2 last = Vector2.zero;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            last = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(Camera.main.transform.up, (last.x - Input.mousePosition.x) * 10 * Time.deltaTime, Space.World);
            transform.Rotate(Camera.main.transform.right, -(last.y - Input.mousePosition.y) * 10 * Time.deltaTime, Space.World);
        }
        last = Input.mousePosition;
    }

}

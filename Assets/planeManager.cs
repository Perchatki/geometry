using UnityEngine;

public class planeManager : MonoBehaviour
{
    [SerializeField] Vector3[] dots;
    [SerializeField] int index;
    [SerializeField] Transform[] dotObjects;
    RaycastHit ray;
    Plane p;
    void Start()
    {
        p = new Plane();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out ray))
            {
                if (index < 2)
                {
                    dotObjects[index].position = ray.point;
                    index++;
                }
                else if (index == 2)
                {
                    dotObjects[index].position = ray.point;
                    index++;
                    p.Set3Points(dotObjects[0].position, dotObjects[1].position, dotObjects[2].position);
                    transform.up = p.normal;
                    transform.position = dotObjects[0].position;
                }
                else
                {
                    dotObjects[0].position = Vector3.one * 10000;
                    dotObjects[1].position = Vector3.one * 10000;
                    dotObjects[2].position = Vector3.one * 10000;
                    transform.position = Vector3.one * 10000;
                    index = 0;
                    dotObjects[0].transform.position = ray.point;
                    index++;
                }
            }
        }
    }
}

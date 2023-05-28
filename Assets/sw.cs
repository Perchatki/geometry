using UnityEngine;

public class sw : MonoBehaviour
{
    int index = 0;
    public void Switch()
    {
        if (index < transform.childCount)
        {
            transform.GetChild(index).gameObject.SetActive(false);
            index++;
            index = (index == transform.childCount) ? 0 : index;
            transform.GetChild(index).gameObject.SetActive(true);
        }
    }
}

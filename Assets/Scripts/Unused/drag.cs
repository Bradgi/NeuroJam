using JetBrains.Annotations;
using UnityEngine;

public class drag : MonoBehaviour
{
    bool dragging = false;
    Vector3 offset;
    float baseZ;

    void Start()
    {

    }

    void Update()
    {
        if (dragging)
        {
            //transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, baseZ));
            transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
    }

    private void OnMouseDown()
    {
        //offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, baseZ));
        transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
    }
}

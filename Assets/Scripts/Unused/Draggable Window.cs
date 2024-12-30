using System;
using UnityEngine;

public class DraggableWindow : MonoBehaviour
{
    [SerializeField] private bool moveRestricted = false;
    [SerializeField] private RectTransform screenArea;

    private bool dragging = false;
    private Vector3 offset;
    private Vector3 extents;

    void Start()
    {
        extents = GetComponent<SpriteRenderer>().sprite.bounds.extents;
    }

    void Update()
    {
        if (dragging)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            if (moveRestricted)
            {
                Vector3 topRight = Camera.main.ViewportToWorldPoint(Vector3.one);
                Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(Vector3.zero);
                pos.x = Mathf.Clamp(pos.x, bottomLeft.x + extents.x, topRight.x - extents.x);
                pos.y = Mathf.Clamp(pos.y, bottomLeft.y + extents.y, topRight.y - extents.y);
            }
            transform.position = pos;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp() 
    {
        dragging = false;
    }
}

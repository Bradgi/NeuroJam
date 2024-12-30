using UnityEngine;

public class CloseImage : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameManager.Instance.imageViewerOpen)
        {
            GameManager.Instance.imageViewerOpen = false;

            GameObject.FindGameObjectWithTag("Images/"+GameManager.Instance.currentlyOpenImage).transform.position = new Vector3(-500,-500,0);

            GameManager.Instance.currentlyOpenImage = "";
        }
    }
}

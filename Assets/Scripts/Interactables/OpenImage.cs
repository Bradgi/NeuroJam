using UnityEngine;

public class OpenImage : MonoBehaviour
{
    [SerializeField] string selectedImage = "";
    private void OnMouseDown()
    {
        if (!GameManager.Instance.imageViewerOpen)
        {
            GameManager.Instance.imageViewerOpen = true;
            GameManager.Instance.currentlyOpenImage = selectedImage;

            GameObject.FindGameObjectWithTag("Images/"+selectedImage).transform.position = new Vector3(1.28999996f,2.0999999f,0);
        }
    }
}

using UnityEngine;

public class Pipes : MonoBehaviour
{
    public Transform top;
    public Transform bottom;
    public float speed = 5f;
    public float gap = 0.5f;

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
       
        Debug.Log("Initial Top Position: " + top.position);
        Debug.Log("Initial Bottom Position: " + bottom.position);

        top.position += Vector3.up * gap / 2;
        bottom.position += Vector3.down * gap / 2;

        // Log the new positions after applying gap adjustment
        Debug.Log("Adjusted Top Position: " + top.position);
        Debug.Log("Adjusted Bottom Position: " + bottom.position);
    }

    private void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;

        if (transform.position.x < leftEdge) {
            Destroy(gameObject);
        }
    }

}

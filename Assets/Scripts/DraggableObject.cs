using UnityEngine;

public class DraggableObject : MonoBehaviour
{
	private Vector3 initialPosition;
	private Vector3 offset;
    private bool isDragging = false;

    private void Start()
	{
		initialPosition = transform.position;
    }

	private void OnMouseDown()
	{
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
	}

	private void OnMouseUp()
	{
        isDragging = false;
        transform.position = initialPosition;
    }

	private void Update()
	{
		if (isDragging)
		{
			Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f)) + offset;
			transform.position = newPosition;
        }
	}
}

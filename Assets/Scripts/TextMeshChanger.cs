using UnityEngine;

public class TextMeshChanger : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 32.0f;
    [SerializeField] private TextMesh _textMesh = null;

    private int _counter = 0;

    private void Update()
    {
        // Rotate us to show off that sweet 3D
        transform.Rotate(0.0f, _rotationSpeed * Time.deltaTime, 0.0f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pressed!");
            _counter = _counter + 1;
            _textMesh.text = "pressed space " + _counter + " times";
        }
    }
}
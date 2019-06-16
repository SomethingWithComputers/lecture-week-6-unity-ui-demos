using UnityEngine;

public class ButtonResponder : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        Debug.Log("Clicked!");
        transform.localScale = transform.localScale * 1.1f;
    }
}

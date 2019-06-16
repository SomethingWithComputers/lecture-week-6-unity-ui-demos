using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Text _textHealth = null;

    private float _health = 100.0f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Ouch!");

            // Take some damage
            _health = _health - 10.0f;
        }

        // Update the UI to reflect our health
        // Maybe change the color based on how "healthy" you are?
        _textHealth.text = "health: <color='#63C74E'>" + Mathf.RoundToInt(_health) + "%</color>";

        // Slowly regain health as well, but never go over 100. Gain 4 health per second
        _health = Mathf.Min(_health + (Time.deltaTime * 4), 100.0f);

        // Also shrink a little bit to indicate that we've been hurt
        transform.localScale = Vector3.one * (_health / 100.0f);
    }
}
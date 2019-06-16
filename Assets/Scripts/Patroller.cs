using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    [SerializeField] private float _patrolRadius = 1.0f;
    [SerializeField] private bool _goVerticalInsteadOfHorizontal = false;

    private float _timePassed = 0.0f;

    private void Update()
    {
        _timePassed += Time.deltaTime;
        Vector3 position = transform.position;
        position.x = Mathf.Sin(_timePassed) * _patrolRadius;
        if (_goVerticalInsteadOfHorizontal)
        {
            position.y = Mathf.Cos(_timePassed) * _patrolRadius;
        }
        else
        {
            position.z = Mathf.Cos(_timePassed) * _patrolRadius;
        }

        transform.position = position;
    }
}
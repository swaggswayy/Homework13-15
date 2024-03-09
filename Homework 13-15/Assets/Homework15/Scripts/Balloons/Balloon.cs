using System;
using UnityEngine;
using static Homework4.ColorsEnum;

[RequireComponent(typeof(Rigidbody))]
public class Balloon : MonoBehaviour
{
    [SerializeField] private Colors _color;

    public Colors Color => _color;

    public event Action<Balloon> BreakBalloon;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Character character))
        {
            BreakBalloon?.Invoke(this);
            Destroy(gameObject);
        }
    }
}

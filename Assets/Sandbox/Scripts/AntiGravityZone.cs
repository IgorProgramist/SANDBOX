using System.Collections.Generic;
using UnityEngine;

namespace Sandbox.S01
{
    [RequireComponent(typeof(Collider))]
    public class AntiGravityZone : MonoBehaviour
    {
        [SerializeField] private float antigravityStrength = 9.81f;

        private readonly HashSet<Rigidbody> _rigidbodies = new HashSet<Rigidbody>();

        private void Reset()
        {
            if (TryGetComponent<Collider>(out var col))
                col.isTrigger = true;
        }

        private void OnValidate()
        {
            if (TryGetComponent<Collider>(out var col) && !col.isTrigger)
                Debug.LogWarning($"[AntiGravityZone] Collider on '{name}' must have isTrigger = true.", this);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<Rigidbody>(out var rb))
                _rigidbodies.Add(rb);
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent<Rigidbody>(out var rb))
                _rigidbodies.Remove(rb);
        }

        private void FixedUpdate()
        {
            _rigidbodies.RemoveWhere(rb => rb == null);

            foreach (var rb in _rigidbodies)
                rb.AddForce(Vector3.up * antigravityStrength, ForceMode.Acceleration);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = new Color(0.2f, 0.8f, 1f, 0.4f);
            if (TryGetComponent<Collider>(out var col))
                Gizmos.DrawWireCube(col.bounds.center, col.bounds.size);
            else
                Gizmos.DrawWireSphere(transform.position, 1f);
        }
    }
}

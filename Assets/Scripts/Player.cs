using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _force;

    private Rigidbody _rigidbody;
    private float _horizontalInput;
    private float _verticalInput;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_horizontalInput, 0, _verticalInput) * _force * Time.deltaTime;
    }
}

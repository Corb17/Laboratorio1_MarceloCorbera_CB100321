using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigiBody;
    private PlayerInput _playerInput;
    private Vector2 _movement;
    [SerializeField] private float _speed = 5F;
    void Start()
    {
        _rigiBody = GetComponent<Rigidbody>();
        _playerInput = GetComponent<PlayerInput>();
    }
    void Update()
    {
        _movement = _playerInput.actions["Movement"].ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
            Movement();
    }
    void Movement()
    {
        Vector3 movePotition = new Vector3(_movement.x, 0f, _movement.y);

        _rigiBody.MovePosition(_rigiBody.position + movePotition * _speed * Time.fixedDeltaTime);
    }
}

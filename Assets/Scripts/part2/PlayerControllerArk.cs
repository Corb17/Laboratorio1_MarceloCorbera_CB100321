using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerArk : MonoBehaviour
{
    private Rigidbody _rigiBodyArk;
    private PlayerInput _playerInputArk;
    private Vector2 _movementArk;
    [SerializeField] private float _speed = 70F;
    void Start()
    {
        _rigiBodyArk = GetComponent<Rigidbody>();
        _playerInputArk = GetComponent<PlayerInput>();
    }
    void Update()
    {
        _movementArk = _playerInputArk.actions["MovementArk"].ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        MovementArk();
    }
    void MovementArk()
    {
        Vector3 movePotition = new Vector3(_movementArk.x, 0f, _movementArk.y);

        _rigiBodyArk.MovePosition(_rigiBodyArk.position + movePotition * _speed * Time.fixedDeltaTime);
    }
}
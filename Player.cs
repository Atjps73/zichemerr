using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _playerHead;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _transform;

    private readonly float _jumpForce = 18.5f;
    private readonly float _delay = 1.5f;

    private bool _isGrounded = true;

    private void OnCollisionEnter(Collision other)
    {
        _isGrounded = true;

        if (other.gameObject.GetComponent<Level>())
            SceneManager.LoadScene(0);  
    }

    private void BendUp()
    {
        _playerHead.SetActive(true);
    }

    public void BendDown()
    {
        _playerHead.SetActive(false);
        Invoke(nameof(BendUp), _delay);
    }

    public void Jump()
    {
        if (_isGrounded)
        {
            _isGrounded = false;
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }
}

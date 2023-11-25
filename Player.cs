using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _sensitivy = 150f;

    private readonly float _rotateZone = Screen.width / 5;

    private void Update()
    {
        if (Input.mousePosition.x < _rotateZone && transform.rotation.eulerAngles.y > 60)
            MovementCamera(-_sensitivy);

        else if (Input.mousePosition.x > Screen.width - _rotateZone && transform.rotation.eulerAngles.y < 120)
            MovementCamera(_sensitivy);
    }
    private void MovementCamera(float _sensitivy)
    {
        transform.Rotate(0, _sensitivy * Time.deltaTime, 0);
    }
}

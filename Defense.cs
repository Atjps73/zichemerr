using UnityEngine;

public class Defense : MonoBehaviour
{
    [SerializeField] private GameObject _RightDoorOpen;
    [SerializeField] private GameObject _chicaDoor;
    [SerializeField] private GameObject _chicaScreamer;

    [SerializeField] private GameObject _leftDoorOpen;
    [SerializeField] private GameObject _bonnieDoor;
    [SerializeField] private GameObject _bonnieScreamer;

    private readonly int _attackDelay = 5;

    private void Update()
    {
        if (_bonnieDoor.activeSelf == true || _chicaDoor.activeSelf == true)
            Invoke(nameof(ScreamerAnimotronic), _attackDelay);
    }

    private void ScreamerAnimotronic()
    {
        AttackCheck(_bonnieDoor, _bonnieScreamer, _leftDoorOpen);
        AttackCheck(_chicaDoor, _chicaScreamer, _RightDoorOpen);
    }

    private void AttackCheck(GameObject animotronicDoor, GameObject animotronicScream, GameObject doorOpen)
    {
        if (doorOpen.activeSelf == true && animotronicDoor.activeSelf == true)
            animotronicScream.SetActive(true);
    }
}


using UnityEngine;

public class OpenCamera : MonoBehaviour
{
    [SerializeField] private GameObject _minimap;
    [SerializeField] private GameObject[] _cameras;
    [SerializeField] private GameObject _mainCamera;

    private readonly int _currentCameraIndex = 0;

    public void TabChangeVisible()
    {
        if (_minimap.activeSelf)
            OpenClose(false, true, false);
        else
            OpenClose(true, false, true);
    }

    private void OpenClose(bool a, bool b, bool c)
    {
        _minimap.SetActive(a);
        _mainCamera.SetActive(b);
        _cameras[_currentCameraIndex].SetActive(c);
    }

    public void ChangeCamera(int index)
    {
        _cameras[_currentCameraIndex].SetActive(false);
        _currentCameraIndex = index;
        _cameras[_currentCameraIndex].SetActive(true);
    }
}

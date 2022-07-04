using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class BackgroundMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private RawImage _imege;
    private float _imegePositionX;

    private void Start()
    {
        _imege = GetComponent<RawImage>();
        _imegePositionX = _imege.uvRect.x;
    }

    private void Update()
    {
        _imegePositionX += _speed * Time.deltaTime;

        if (_imegePositionX > 1)
            _imegePositionX = 0;

        _imege.uvRect = new Rect(_imegePositionX, 0, _imege.uvRect.width, _imege.uvRect.height);
    }
}

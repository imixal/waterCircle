using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobRenderer : MonoBehaviour
{
    [SerializeField] private float _period = 10f;
    [SerializeField] private float _speedSeed = 0.7f;
    [SerializeField] private float _minSpeed = 0.3f;
    [SerializeField] private float _maxSpeed = 0.7f;
    [SerializeField] private float _startRendererTime = 3f;

    private float _timer;
    private int _blobCount;

    private Blob _blob;

    private void Awake()
    {
        _blob = Resources.Load<Blob>("Blob");
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _startRendererTime && _timer / _period > _blobCount)
        {
            var randomValue = Random.value;
            float x;
            if ((int) (randomValue * 100) % 2 == 1)
            {
                x = Random.value * 50;
            }
            else
            {
                x = Random.value * 50 * -1;
            }
            var position = new Vector3(x, transform.position.y);
            var blob = Instantiate(_blob, position, new Quaternion(180f, 0, 0, 0));
            var speed = Random.value * _speedSeed;
            if (speed > _maxSpeed)
                speed = _maxSpeed;
            else if (speed < _minSpeed)
                speed = _minSpeed;
            blob.Speed = speed;
            _blobCount++;
        }
    }
}

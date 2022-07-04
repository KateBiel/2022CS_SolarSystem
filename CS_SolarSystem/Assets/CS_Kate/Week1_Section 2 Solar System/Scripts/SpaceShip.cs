using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    [SerializeField] private AnimationCurve _curve;
   // [SerializeField] private Vector3 _goalPosition;
    [SerializeField] private Vector3 _rotationGoal;
   // [SerializeField] private float _goalscale = 2;
    [SerializeField] private float _speed = 20f;
    [SerializeField] private Transform _startpoint;
    [SerializeField] private Transform _endpoint;

    private float _current, _target; 

    // Start is called before the first frame update
    void Start()
    {
        var myValue = Mathf.Lerp(0, 30, 10f); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) _target = _target == 0 ? 1 : 0;

        _current = Mathf.MoveTowards(_current, _target, _speed * Time.deltaTime);

        transform.position = Vector3.Lerp(_startpoint.position, _endpoint.position, _curve.Evaluate(_current));
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(_startpoint.position), Quaternion.Euler(_rotationGoal), _curve.Evaluate(_current));
      //  transform.localScale = Vector3.Lerp(Vector3.one, Vector3.one, _curve.Evaluate(Mathf.PingPong(_current, 0.5f)));
    }
}

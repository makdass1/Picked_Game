using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] public Rigidbody _rigitbody; 
    // Start is called before the first frame update
    void Start()
    {
        _rigitbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigitbody.velocity = new Vector3(x: Input.GetAxisRaw("Horizontal") * Time.fixedDeltaTime * 50, y: 0,
            z: Input.GetAxisRaw("Vertical") * 50 * Time.fixedDeltaTime);
    }
}

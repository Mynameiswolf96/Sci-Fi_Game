using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Shoot
{
    public class MovePolyartCharacter : MonoBehaviour
    {
        private Vector3 direction;
        [SerializeField] private float speed = 5f;
        [SerializeField] private float runSpeed = 10;
        private string horizont = "Horizontal";
        private string vertical = "Vertical";
        private string run = "Run";
        private string IsMove = "IsMove";
        private bool IsRunning;
        private Animator anim;
        private void Start()
        {
            anim = GetComponent<Animator>();
        }
        private void Update()
        {
            direction.x = Input.GetAxis(horizont);
            direction.z = Input.GetAxis(vertical);
            IsRunning = Input.GetButton(run);
        }
        
        private void FixedUpdate()
        {
            transform.position += direction*Time.fixedDeltaTime*(IsRunning?runSpeed:speed);
            if(Input.GetButton(vertical) || Input.GetButton(horizont))
            {
                anim.SetBool(IsMove, true);
                    
            }
            else
            {
                anim.SetBool(IsMove, false);
            }
        }
    }
}
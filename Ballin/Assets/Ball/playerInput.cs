using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityStandardAssets.Vehicles.Ball
{
    public class playerInput : MonoBehaviour
    {
        private BallController ball; // Reference to the ball controller.

        private Vector3 move;
        // the world-relative desired move direction, calculated from the camForward and user input.

        private Transform cam; // A reference to the main camera in the scenes transform
        private Vector3 camForward; // The current forward direction of the camera
        private bool jump; // whether the jump button is currently pressed

        public InputAction moveAction;  // move 
        public InputAction jumpAction;  // jump

        private void OnEnable()
        {
            moveAction.Enable();
            jumpAction.Enable();
            jumpAction.performed += OnJump;
            jumpAction.canceled += OnJump;
        }

        private void OnDisable()
        {
            jumpAction.performed -= OnJump;
            jumpAction.canceled -= OnJump;

            moveAction.Disable();
            jumpAction.Disable();
        }

        private void Awake()
        {
            // Set up the reference.
            ball = GetComponent<BallController>();


            // get the transform of the main camera
            if (Camera.main != null)
            {
                cam = Camera.main.transform;
            }
            else
            {
                Debug.LogWarning(
                    "Warning: no main camera found. Ball needs a Camera tagged \"MainCamera\", for camera-relative controls.");
                // we use world-relative controls in this case, which may not be what the user wants, but hey, we warned them!
            }
        }


        private void Update()
        {
            // Get the axis and jump input.

            Vector2 mov = moveAction.ReadValue<Vector2>();

            float h = mov.x;
            float v = mov.y;

            // calculate move direction
            if (cam != null)
            {
                // calculate camera relative direction to move:
                camForward = Vector3.Scale(cam.forward, new Vector3(1, 0, 1)).normalized;
                move = (v * camForward + h * cam.right).normalized;
            }
            else
            {
                // we use world-relative directions in the case of no main camera
                move = (v * Vector3.forward + h * Vector3.right).normalized;
            }
        }


        private void FixedUpdate()
        {
            // Call the Move function of the ball controller
            ball.Move(move, jump);
            jump = false;
        }
        public void OnJump(InputAction.CallbackContext ctx)
        {
            if (ctx.performed)
                jump = true;
            else
                jump = false;
        }
    }

}

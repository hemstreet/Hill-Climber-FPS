using UnityEngine;

namespace Player
{
    [RequireComponent (typeof(CharacterController))]
    public class FirstPersonController : MonoBehaviour {

        [Header("Player Variables")]
        public string username;
        public float health = 100;

        [Header("Movement")]
        public float movementSpeed = 10f;
        public float mouseSensitivity = 2.0f;
        public float jumpSpeed = 7f;
        public float cameraRollRange = 60.0f;
        private float verticalRotation = 0;
        private float verticalVelocity = 0;

        [Header("Character")]
        public CharacterController characterController;

        void IniitalizePlayerVariables()
        {
            PlayerVariables.health = health;
        }

        // Use this for initialization
        void Start () {
            Cursor.lockState = CursorLockMode.Locked;
            characterController = GetComponent<CharacterController>();

            IniitalizePlayerVariables();
        }

        // Update is called once per frame
        void Update () {

            float yaw = Input.GetAxis("Mouse X") * mouseSensitivity;

            transform.Rotate (0, yaw, 0);

            verticalRotation -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
            verticalRotation = Mathf.Clamp (verticalRotation, -cameraRollRange, cameraRollRange);
            Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);

            MoveCheck();

            JumpCheck();

        }


        void MoveCheck()
        {
            float forwardSpeed = Input.GetAxis ("Vertical") * movementSpeed;
            float sideSpeed = Input.GetAxis ("Horizontal") * movementSpeed;

            Vector3 speed = new Vector3 (sideSpeed, verticalVelocity, forwardSpeed);

            speed = transform.rotation * speed;

            characterController.Move(speed * Time.deltaTime);
        }

        void JumpCheck()
        {
            if (characterController.isGrounded)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    verticalVelocity = jumpSpeed;
                }
            }

            verticalVelocity += Physics.gravity.y * Time.deltaTime;

            PlayerVariables.altitude = gameObject.transform.localPosition.y;

        }
    }

}
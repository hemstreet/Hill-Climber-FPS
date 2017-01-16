using UnityEngine;
using UnityEngine.Networking;

[RequireComponent (typeof(CharacterController))]
public class FirstPersonControllerNetwork : NetworkBehaviour {

    [Header("Movement")]
    public float MovementSpeed = 10f;
    public float MouseSensitivity = 2.0f;
    public float JumpSpeed = 7f;

    [Header("Camera")]
    public float CameraRollRange = 60.0f;
    public float BaseCameraHeight = 1.75f;

    [Header("Character")]
    public CharacterController CharacterController;

    private float _verticalVelocity = 0;
    private Transform mainCamera;

    // Use this for initialization
    void Start ()
    {
        if (!isLocalPlayer)
        {
            Destroy(this);
            return;
        }

        mainCamera = Camera.main.transform;

        Cursor.lockState = CursorLockMode.Locked;

        CharacterController = GetComponentInChildren<CharacterController> ();
    }


    // Update is called once per frame
    void Update ()
    {

        float yaw = Input.GetAxis("Mouse X") * MouseSensitivity;

        this.transform.Rotate (0, yaw, 0);


        // Movement
        float forwardSpeed = Input.GetAxis ("Vertical") * MovementSpeed;
        float sideSpeed = Input.GetAxis ("Horizontal") * MovementSpeed;

        if (CharacterController.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                _verticalVelocity = JumpSpeed;

            }
        }

        _verticalVelocity += Physics.gravity.y * Time.deltaTime;

        Vector3 speed = new Vector3 (sideSpeed, _verticalVelocity, forwardSpeed);

        speed = this.transform.rotation * speed;

        CharacterController.Move (speed * Time.deltaTime);

        // Move the camera
        MoveCamera();

    }

    void MoveCamera()
    {

        mainCamera.position = new Vector3(transform.position.x,
                                          transform.position.y + BaseCameraHeight,
                                          transform.position.z);
        mainCamera.rotation = transform.rotation;
    }
}
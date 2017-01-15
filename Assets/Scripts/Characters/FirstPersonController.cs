using UnityEngine;

[RequireComponent (typeof(CharacterController))]
public class FirstPersonController : MonoBehaviour {

	public float MovementSpeed = 10f;
	public float MouseSensitivity = 2.0f;
	public float JumpSpeed = 7f;
	public float CameraRollRange = 60.0f;
	public CharacterController CharacterController;

    private float _verticalRotation = 0;
    private float _verticalVelocity = 0;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		CharacterController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		float yaw = Input.GetAxis("Mouse X") * MouseSensitivity;
		
		this.transform.Rotate (0, yaw, 0);

		_verticalRotation -= Input.GetAxis ("Mouse Y") * MouseSensitivity;
		_verticalRotation = Mathf.Clamp (_verticalRotation, -CameraRollRange, CameraRollRange);
		Camera.main.transform.localRotation = Quaternion.Euler (_verticalRotation, 0, 0);
			
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

	}
}

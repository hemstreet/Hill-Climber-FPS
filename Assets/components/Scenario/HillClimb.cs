using UnityEngine;

public class HillClimb : MonoBehaviour
{
    [Header("Options")]
    public float timer = 50f;
    public string levelKey = "level01";

    void Setup()
    {
        GlobalVariables.timer = timer;
    }

	void Update () {
	    GlobalVariables.timer -= Time.deltaTime;

	    if (GlobalVariables.timer <= 0) {
	        Application.LoadLevel(levelKey);
	    }
	}
}

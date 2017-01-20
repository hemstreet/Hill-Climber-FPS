using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    public Text _health;

    // Use this for initialization
    void Start ()
    {
        _health.text = "Health";
    }

    // Update is called once per frame
    void Update () {

    }

    public void UpdateHealth(float hp)
    {

        _health.text = "Health" + hp.ToString();
    }

    public void UpdateAmmo(float amount, int clips)
    {

    }
}

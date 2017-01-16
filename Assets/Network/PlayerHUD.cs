using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour
{
    private Text _health;

    // Use this for initialization
    void Start ()
    {
        _health = GetComponent<Text>();
        _health.text = "Health" + 100f;
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

using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text timeLapsed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLapsed.text = "" + Mathf.Round(Time.timeSinceLevelLoad * 100f) / 100f;
    }
}

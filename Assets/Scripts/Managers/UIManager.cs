using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public RobotController robot;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI positionText;
    public TextMeshProUGUI rotationText;
    public Button resetButton;

    void Start()
    {
        resetButton.onClick.AddListener(robot.ResetPosition);
    }

    void Update()
    {
        speedText.text = $"Speed: {robot.GetSpeed():F2}";
        positionText.text = $"Position: X:{robot.GetPosition().x:F2} Z:{robot.GetPosition().z:F2}";
        rotationText.text = $"Rotation: {robot.GetRotation():F2}°";
    }
}

using UnityEngine;
using UnityEngine.UI;

public class research : MonoBehaviour
{
    void Start()
    {
        // Create a Canvas
        GameObject canvasGO = new GameObject("Canvas");
        Canvas canvas = canvasGO.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvasGO.AddComponent<CanvasScaler>();
        canvasGO.AddComponent<GraphicRaycaster>();

        // Create a Button
        GameObject buttonGO = new GameObject("MyButton");
        buttonGO.transform.SetParent(canvasGO.transform);

        // Add Image component to the Button
        Image image = buttonGO.AddComponent<Image>();
        image.color = Color.cyan; // Set button color

        // Add Button component
        Button button = buttonGO.AddComponent<Button>();
        button.onClick.AddListener(OnButtonClick);

        // Create Text for the Button
        GameObject textGO = new GameObject("ButtonText");
        textGO.transform.SetParent(buttonGO.transform);
        Text text = textGO.AddComponent<Text>();
        text.text = "Click Me!";
        text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        text.alignment = TextAnchor.MiddleCenter;
        text.color = Color.black;

        // Set RectTransform for Button
        RectTransform buttonRect = buttonGO.GetComponent<RectTransform>();
        buttonRect.sizeDelta = new Vector2(160, 30);
        buttonRect.anchoredPosition = new Vector2(0, 0);

        // Set RectTransform for Text
        RectTransform textRect = textGO.GetComponent<RectTransform>();
        textRect.sizeDelta = buttonRect.sizeDelta;
        textRect.anchoredPosition = Vector2.zero;
    }

    void OnButtonClick()
    {
        Debug.Log("Button was clicked!");
    }
}

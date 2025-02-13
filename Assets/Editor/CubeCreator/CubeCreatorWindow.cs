using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeCreatorWindow : EditorWindow
{
    [MenuItem("Primitive Creator/Cube Creator")]
    public static void ShowExample()
    {
        CubeCreatorWindow wnd = GetWindow<CubeCreatorWindow>();
        wnd.titleContent = new GUIContent("CubeCreatorWindow");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy
        Label label = new Label("Hello World!");
        root.Add(label);

        // Create button
        Button button = new Button();
        button.name = "button";
        button.text = "Button";
        root.Add(button);

        // Create toggle
        Toggle toggle = new Toggle();
        toggle.name = "toggle";
        toggle.label = "Toggle";
        root.Add(toggle);
    }

    // usar algun metodo de la clase GameObject para crear un cubo con las dimensiones especificadas (en cm)
}

using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;

public class FoliageGenerator : MonoBehaviour
{
    [SerializeField] private int genWidth;
    [SerializeField] private int genHeight;
}

[CustomEditor(typeof(FoliageGenerator)), CanEditMultipleObjects]

public class FoliageGeneratorEditor : Editor
{
    public override VisualElement CreateInspectorGUI()
    {
        //Root
        VisualElement root = new VisualElement();

        VisualTreeAsset asset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/UXML/FoliageGeneratorEditor.uxml");
        asset.CloneTree();


        return root;
    }
}
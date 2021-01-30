using UnityEngine;
using UnityEngine.UI;
 
public class FlexibleGridLayout : MonoBehaviour
{
    float defaultRatio16_9 = 1.777133f;
    GridLayoutGroup layout;
    // Start is called before the first frame update
    void Start()
    {
        layout = GetComponent<GridLayoutGroup>();
        if (Camera.main is null) return;
        var aspect = Camera.main.aspect;
        var padding = layout.padding;
        layout.cellSize /= aspect / defaultRatio16_9;
        padding.left = (int) (padding.left / (aspect / defaultRatio16_9));
        padding.right = (int) (padding.left / (aspect / defaultRatio16_9));
        padding.top = (int) (padding.left / (aspect / defaultRatio16_9));
        padding.bottom = (int) (padding.left / (aspect / defaultRatio16_9));
        layout.spacing /= aspect / defaultRatio16_9;
    }
}
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int Points = 0;

    public TMP_Text Text;

    private bool pointsChanged;

    void Update()
    {
        // "Jump" refers to a name that is associated to the space button
        // Go in "Project Settings" > "Input Manager". Find "Jump" under the Axes.
        // You will see that the "positive button" is "space".

        // NOTE: Unity is working on a new Input Manager called Input System. It's much better than the current one.
        //       https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/index.html

        if (Input.GetButtonDown("Jump"))
        {
            Points += 1;
            pointsChanged = true;
        }
    }

    void LateUpdate()
    {
        // We use LateUpdate() because we do not want to update the UI in Update().
        // This is helpful in situations where the Points are updated multiple times.
        // We only update the text once in LateUpdate() instead of every single time the Points change.

        if (pointsChanged)
        {
            pointsChanged = false;
            Text.SetText(Points.ToString());
        }
    }
}

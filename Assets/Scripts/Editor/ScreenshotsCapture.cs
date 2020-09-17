using UnityEditor;
using UnityEngine;

public class ScreenshotsCapture 
{
    static string folderName = "Screenshots";

    [MenuItem("Tools/CaptureSceenshot #S")]
    static void AnchorsToCorners()
    {
        if (!System.IO.Directory.Exists(folderName))
            System.IO.Directory.CreateDirectory(folderName);
        ScreenCapture.CaptureScreenshot(folderName+"/"+System.DateTime.Now.ToString("ddMMyyHHmmss") + ".png");
    }
}

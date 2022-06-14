using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using Unity.PerformanceTesting;

public class FrameTime_PlayMode
{
    [UnityTest, Performance]
    public IEnumerator FrameTime_In_PlayMode()
    {
        SceneManager.LoadScene("SampleScene");
        yield return Measure.Frames().WarmupCount(10).MeasurementCount(20).Run();
    }
}

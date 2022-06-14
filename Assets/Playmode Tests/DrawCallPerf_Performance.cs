using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Unity.PerformanceTesting;
using UnityEngine.SceneManagement;

public class DrawCallPerf_Performance
{
    [UnityTest, Performance]
    public IEnumerator DrawCallPerf_PerformanceWithEnumeratorPasses()
    {
        AsyncOperation asyncLoadLevel = SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Single);

        while (!asyncLoadLevel.isDone)
        {
            yield return null;
        }

        yield return new WaitForSeconds(2f);

        using (Measure.Frames().Scope("FrameTime")) 
        {
            yield return new WaitForSeconds(3f);
        }
    }
}

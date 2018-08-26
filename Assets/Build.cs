using UnityEditor;

public class Build {
    public static void PerformBuild() {
        BuildPipeline.BuildPlayer(new[] {"SampleScene"}, "Build/GitDemo.apk", BuildTarget.Android, BuildOptions.Development);
    }
}
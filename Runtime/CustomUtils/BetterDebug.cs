using System.Diagnostics;
using Debug = UnityEngine.Debug;
using Color = UnityEngine.Color;

namespace Utils
{
    public static class BetterDebug
    {
        private static bool canLog = true;
        public static void CanLog(bool state) => canLog = state;
        public static void Log(object text, Color color = default)
        {
            if (!canLog) return;

            StackTrace stackTrace = new StackTrace(true);
            StackFrame frame = stackTrace.GetFrame(1);
            string callingMethod = $"{frame.GetFileName()}:{frame.GetFileLineNumber()}";

            var colorHex = color == default ? Color.white.GetHex() : color.GetHex();
            Debug.Log($"<color={colorHex}>{text}</color>\n{callingMethod}");
        }
    }
}
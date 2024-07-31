using UnityEngine;

namespace Runtime.Utils
{
    public static class BetterDebug
    {
        private static bool canLog = true;
        public static void CanLog(bool state) => canLog = state;
        public static void Log(object text, Color color = default)
        {
            if (!canLog) return;
            var colorHex = color == default ? Color.white.GetHex() : color.GetHex();
            Debug.Log($"<color={colorHex}>{text}</color>");
        }
    }
}
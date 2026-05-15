using UnityEngine;

/// <summary>
/// Logger - Hệ thống logging cho debug
/// </summary>
public static class Logger
{
    public enum LogLevel
    {
        Info,
        Warning,
        Error,
        Success
    }

    public static void Log(string message, LogLevel level = LogLevel.Info)
    {
        string prefix = "";
        
        switch (level)
        {
            case LogLevel.Info:
                prefix = "[INFO]";
                Debug.Log($"{prefix} {message}");
                break;
            case LogLevel.Warning:
                prefix = "[WARNING]";
                Debug.LogWarning($"{prefix} {message}");
                break;
            case LogLevel.Error:
                prefix = "[ERROR]";
                Debug.LogError($"{prefix} {message}");
                break;
            case LogLevel.Success:
                prefix = "[SUCCESS]";
                Debug.Log($"<color=green>{prefix} {message}</color>");
                break;
        }
    }

    public static void LogGameEvent(string eventName, string details)
    {
        Log($"Event: {eventName} - {details}", LogLevel.Info);
    }

    public static void LogPlayerAction(string action)
    {
        Log($"Player Action: {action}", LogLevel.Info);
    }

    public static void LogTrafficViolation(string violationType)
    {
        Log($"Traffic Violation: {violationType}", LogLevel.Warning);
    }

    public static void LogCollision(string colliderName)
    {
        Log($"Collision detected with: {colliderName}", LogLevel.Warning);
    }
}

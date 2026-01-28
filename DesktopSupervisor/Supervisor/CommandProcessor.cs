using DesktopSupervisor.Models;
using System.Diagnostics;

namespace DesktopSupervisor.Supervisor
{
    public static class CommandProcessor
    {
        public static string Process(QPointCommand command)
        {
            Debug.WriteLine($"COMMAND RECEIVED: {command.Action}");

            switch (command.Action)
            {
                case "Move":
                    return "Robot is moving";

                case "Grip":
                    return "Gripper engaged";

                case "Release":
                    return "Gripper released";

                case "Start":
                    return "Auto mode started";

                default:
                    return $"Unknown command: {command.Action}";
            }
        }
    }
}

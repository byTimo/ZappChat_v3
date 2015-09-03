﻿using System;
using System.Windows.Input;

namespace ZappChat_v3.Core.Managers
{
    public static class CommandManager
    {
        public static event Action<string> PreviewExecuteCommand;
        public static event Action CloseCurrentContent;
        static CommandManager()
        {
            OpenGroupSettingCommand = new Command("OpenGroupSetting", OnPreviewExecuteCommand);
            OpenGroupCreateCommand = new Command("OpenGroupCreate", OnPreviewExecuteCommand);
            GroupCreateCommand = new Command("GroupCreate", OnPreviewExecuteCommand);
            GroupDeleteCommand = new Command("GroupDelete", OnPreviewExecuteCommand);
            AddFriendInGroupCommand = new Command("AddFriendInGroup", OnPreviewExecuteCommand);
            AddFriendCommand = new Command("AddFriend", OnPreviewExecuteCommand);
        }

        public static Command OpenGroupSettingCommand { get; }
        public static Command OpenGroupCreateCommand { get; }
        public static Command GroupCreateCommand { get; }
        public static Command GroupDeleteCommand { get; }
        public static Command AddFriendInGroupCommand { get; }
        public static Command AddFriendCommand { get; }

        /// <summary>
        /// Возвращает объект команды по её имени.
        /// </summary>
        /// <param name="commandName">Имя команды</param>
        /// <returns>Команда с заданным имененем</returns>
        public static Command GetCommand(string commandName)
        {
            switch (commandName)
            {
                case "OpenGroupSetting":
                    return OpenGroupSettingCommand;
                case "OpenGroupCreate":
                    return OpenGroupCreateCommand;
                case "GroupCreate":
                    return GroupCreateCommand;
                case "GroupDelete":
                    return GroupDeleteCommand;
                case "AddFriendInGroup":
                    return AddFriendInGroupCommand;
                case "AddFriend":
                    return AddFriendCommand;
                default:
                    throw new ArgumentException("Неизвестное имя команды");
            }

        }

        private static void OnPreviewExecuteCommand(string obj)
        {
            PreviewExecuteCommand?.Invoke(obj);
        }

        public static void CloseContnt()
        {
            CloseCurrentContent?.Invoke();
        }
    }
}
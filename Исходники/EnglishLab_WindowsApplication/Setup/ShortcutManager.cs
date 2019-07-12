using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setup
{
    public enum ShortcutLocation
    {
        DESKTOP,
        COMMON_DESKTOP,
        START_MENU
    }

    public class ShortcutManager
    {
        public static void CreateShortcut(string linkName, string apppath, string iconpath, ShortcutLocation location, string hotkey)
        {
            object shortPath = null;
            // Определяем место, где будет создан ярлык
            switch (location)
            {
                case ShortcutLocation.DESKTOP:
                    {
                        shortPath = (object)"Desktop";
                    }; break;
                case ShortcutLocation.START_MENU:
                    {
                        shortPath = (object)"StartMenu";
                    }; break;
                case ShortcutLocation.COMMON_DESKTOP:
                    {
                        shortPath = (object)"AllUsersDesktop";
                    }; break;
                default: shortPath = (object)"Desktop"; break;
            }

            WshShell shell = new WshShell();
            // Получаем полный адрес ярлыка
            string link = Path.Combine(((string)shell.SpecialFolders.Item(ref shortPath)), linkName + @".lnk");
            // Создаем объект ярлыка
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(link);
            if (!hotkey.Equals(String.Empty))
            {
                // Назначаем горячую клавишу
                shortcut.Hotkey = hotkey;
            }
            // Описание ярлыка
            shortcut.Description = linkName;

            shortcut.IconLocation = iconpath;
            //Указываем рабочую папку
            shortcut.WorkingDirectory = Path.GetDirectoryName(apppath);
            // Указываем путь для программы
            shortcut.TargetPath = apppath;
            // Вызываем метод Save(), который и создаст ярлык 
            shortcut.Save();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace CoLocatedCardSystem.CollaborationWindow.Layers
{
    class MenuBarInfo
    {
        private Size size = new Size(800, 60);
        private Point position = new Point(0, 0);
        private double scale = 1;
        private double rotate = 1;
        KeyboardButtonAttr keyboardButtonInfo=new KeyboardButtonAttr();
        KeyboardAttr keyboardInfo = new KeyboardAttr();
        InputTextBox inputTextBlockInfo = new InputTextBox();
        protected static Dictionary<User, MenuBarInfo> menubarInfoList = new Dictionary<User, MenuBarInfo>();
        internal Size Size
        {
            get
            {
                return size;
            }
        }
        internal Point Position
        {
            get
            {
                return position;
            }
        }
        internal double Scale
        {
            get
            {
                return scale;
            }
        }
        internal double Rotate
        {
            get
            {
                return rotate;
            }
        }
        internal KeyboardButtonAttr KeyboardButtonInfo
        {
            get
            {
                return keyboardButtonInfo;
            }
        }
        internal KeyboardAttr KeyboardInfo
        {
            get
            {
                return keyboardInfo;
            }
        }
        internal InputTextBox InputTextBoxInfo
        {
            get
            {
                return inputTextBlockInfo;
            }
        }

        static MenuBarInfo()
        {
            menubarInfoList.Add(User.ALEX, InitAlex());
            menubarInfoList.Add(User.BEN, InitBen());
            menubarInfoList.Add(User.CHRIS, InitChris());
            menubarInfoList.Add(User.DANNY, InitDanny());
        }
        /// <summary>
        /// Get the menubar info of the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static MenuBarInfo GetMenuBarInfo(User user)
        {
            return menubarInfoList[user];
        }
        /// <summary>
        /// Initialize Alex's menu bar
        /// </summary>
        /// <returns></returns>
        private static MenuBarInfo InitAlex()
        {
            MenuBarInfo info = new MenuBarInfo();
            info.size = new Size(800, 60);
            info.position = new Point(info.Size.Height, (Screen.HEIGHT - info.Size.Width) / 2);
            info.scale = 1;
            info.rotate = 90;
            return info;
        }
        /// <summary>
        /// Initialize Ben's menu bar
        /// </summary>
        /// <returns></returns>
        private static MenuBarInfo InitBen()
        {
            MenuBarInfo info = new MenuBarInfo();
            info.size = new Size(800, 60);
            info.position = new Point((Screen.WIDTH - info.size.Width) / 2, Screen.HEIGHT - info.size.Height);
            info.scale = 1;
            info.rotate = 0;
            return info;
        }
        /// <summary>
        /// Initialize Chris's menu bar
        /// </summary>
        /// <returns></returns>
        private static MenuBarInfo InitChris()
        {
            MenuBarInfo info = new MenuBarInfo();
            info.size = new Size(800, 60);
            info.position = new Point(Screen.WIDTH - info.size.Height, (Screen.HEIGHT + info.Size.Width) / 2);
            info.scale = 1;
            info.rotate = 270;
            return info;
        }
        /// <summary>
        /// Initialize Danny's menu bar
        /// </summary>
        /// <returns></returns>
        private static MenuBarInfo InitDanny()
        {
            MenuBarInfo info = new MenuBarInfo();
            info.size = new Size(800, 60);
            info.position = new Point((Screen.WIDTH + info.Size.Width) / 2, info.Size.Height);
            info.scale = 1;
            info.rotate = 180;
            return info;
        }

        internal class KeyboardButtonAttr
        {
            Point position = new Point(50, 10);
            Size size = new Size(150, 40);
            public Point Position
            {
                get
                {
                    return position;
                }
            }
            public Size Size
            {
                get
                {
                    return size;
                }
            }
        }

        internal class KeyboardAttr
        {
            Point position = new Point(0, -200);
            Size size = new Size(600, 200);
            public Point Position
            {
                get
                {
                    return position;
                }
            }
            public Size Size
            {
                get
                {
                    return size;
                }
            }
        }

        internal class InputTextBox {
            Point position = new Point(0, -230);
            Size size = new Size(600, 20);
            public Point Position
            {
                get
                {
                    return position;
                }
            }
            public Size Size
            {
                get
                {
                    return size;
                }
            }
        }
    }
}

﻿namespace XamlIconLibrary
{
    public enum GoogleMaterialIcons
    {
        _Default,
        _3DRotation,
        Accessibility,
        AccountBalance,
        AccountBalanceWallet,
        AccountBox,
        AccountCircle,
        AddShoppingCart,
        Alarm,
        AlarmAdd,
        AlarmOff,
        AlarmOn,
        AllOut,
        Android,
        Announcement,
        AspectRatio,
        Assessment,
        AssessmentInd,
        AssessmentLate,
        Assignment,
        Add,
        ArrowDownward,
        ArrowUpward,
        AttachFile,
        AttachMoney,
        BorderColor,
        Clear,
        Code,
        ContentCopy,
        Delete,
        DeleteForever,
        Eject,
        FastForward,
        FastRewind,
        Fingerprint,
        FormatColorFill,
        Forward5,
        Forward10,
        Forward30,
        Fullscreen,
        KeyboardArrowDown,
        KeyboardArrowUp,
        Pause,
        PlayArrow,
        Replay,
        Replay5,
        Replay10,
        Replay30,
        Reply,
        ReplyAll,
        RotateLeft,
        RotateRight,
        Settings,
        SkipNext,
        SkipPrevious,
        Speaker,
        StarHalf,
        Stop,
        Swaphoriz,
        Weekend,
        Wrench,
        YouTubePlay,
        ZipBox
    };

    
    internal static class GoogleMaterialIconsHelper
    {
        /// <summary>
        /// Method used to return the data string when the GoogleMaterialIcons property is updated
        /// </summary>
        public static string UpdateData(GoogleMaterialIcons icon)
        {
            string data = "";

            switch (icon)
            {
                case GoogleMaterialIcons._Default:
                    data = "";
                    break;
                case GoogleMaterialIcons._3DRotation:
                    data = "F1 M25,25z M-1,-1z M7.52,21.48C4.25,19.94,1.91,16.76,1.55,13L0.05,13C0.56,19.16,5.71,24,12,24L12.66,23.97 8.85,20.16 7.52,21.48z M8.41,14.96C8.22,14.96 8.04,14.93 7.89,14.88 7.73,14.82 7.6,14.75 7.49,14.64 7.38,14.54 7.29,14.42 7.23,14.27 7.17,14.13 7.14,13.97 7.14,13.8L5.84,13.8C5.84,14.16 5.91,14.48 6.05,14.75 6.19,15.02 6.38,15.25 6.61,15.44 6.85,15.62 7.12,15.76 7.43,15.85 7.73,15.95 8.05,16 8.39,16 8.76,16 9.11,15.95 9.42,15.85 9.74,15.75 10.02,15.6 10.25,15.41 10.48,15.22 10.67,14.98 10.8,14.69 10.93,14.4 11,14.08 11,13.72 11,13.53 10.98,13.34 10.93,13.16 10.88,12.98 10.81,12.81 10.7,12.65 10.6,12.49 10.46,12.35 10.3,12.22 10.13,12.09 9.93,11.99 9.69,11.91 9.89,11.82 10.06,11.71 10.21,11.58 10.36,11.45 10.48,11.31 10.58,11.16 10.68,11.01 10.75,10.86 10.8,10.7 10.85,10.54 10.87,10.38 10.87,10.22 10.87,9.86 10.81,9.54 10.69,9.26 10.57,8.98 10.4,8.75 10.18,8.57 9.98,8.38 9.71,8.24 9.41,8.14 9.1,8.05 8.76,8 8.39,8 8.03,8 7.7,8.05 7.39,8.16 7.09,8.27 6.82,8.42 6.6,8.61 6.39,8.8 6.22,9.02 6.09,9.28 5.97,9.54 5.91,9.82 5.91,10.13L7.21,10.13C7.21,9.96 7.24,9.81 7.3,9.68 7.36,9.55 7.44,9.43 7.55,9.34 7.66,9.25 7.78,9.17 7.93,9.12 8.08,9.07 8.23,9.04 8.41,9.04 8.81,9.04 9.11,9.14 9.3,9.35 9.49,9.55 9.59,9.84 9.59,10.21 9.59,10.39 9.56,10.55 9.51,10.7 9.46,10.85 9.37,10.97 9.26,11.07 9.15,11.17 9.01,11.25 8.85,11.31 8.69,11.37 8.49,11.4 8.27,11.4L7.5,11.4 7.5,12.43 8.27,12.43C8.49,12.43 8.69,12.45 8.87,12.5 9.05,12.55 9.2,12.63 9.32,12.73 9.44,12.84 9.54,12.97 9.61,13.13 9.68,13.29 9.71,13.48 9.71,13.7 9.71,14.11 9.59,14.42 9.36,14.63 9.13,14.86 8.81,14.96 8.41,14.96z M16.96,9.04C16.64,8.71 16.26,8.45 15.82,8.27 15.39,8.09 14.9,8 14.36,8L12,8 12,16 14.3,16C14.85,16 15.36,15.91 15.81,15.73 16.26,15.55 16.65,15.3 16.97,14.97 17.29,14.64 17.54,14.24 17.71,13.78 17.88,13.31 17.97,12.79 17.97,12.21L17.97,11.81C17.97,11.23 17.88,10.71 17.71,10.24 17.53,9.77 17.28,9.37 16.96,9.04z M16.57,12.2C16.57,12.62 16.52,12.99 16.43,13.33 16.33,13.66 16.19,13.95 16,14.18 15.81,14.41 15.57,14.59 15.29,14.71 15,14.83 14.67,14.89 14.3,14.89L13.39,14.89 13.39,9.12 14.36,9.12C15.08,9.12 15.63,9.35 16,9.81 16.38,10.27 16.57,10.93 16.57,11.8L16.57,12.2z M12,0L11.34,0.03 15.15,3.84 16.48,2.51C19.75,4.06,22.09,7.23,22.44,10.99L23.94,10.99C23.44,4.84,18.29,0,12,0z";
                    break;
                case GoogleMaterialIcons.Accessibility:
                    data = "F1 M24,24z M0,0z M12,2C13.1,2 14,2.9 14,4 14,5.1 13.1,6 12,6 10.9,6 10,5.1 10,4 10,2.9 10.9,2 12,2z M21,9L15,9 15,22 13,22 13,16 11,16 11,22 9,22 9,9 3,9 3,7 21,7 21,9z";
                    break;
                case GoogleMaterialIcons.AccountBalance:
                    data = "F1 M24,24z M0,0z M4,10L4,17 7,17 7,10 4,10z M10,10L10,17 13,17 13,10 10,10z M2,22L21,22 21,19 2,19 2,22z M16,10L16,17 19,17 19,10 16,10z M11.5,1L2,6 2,8 21,8 21,6 11.5,1z";
                    break;
                case GoogleMaterialIcons.AccountBalanceWallet:
                    data = "F1 M24,24z M0,0z M21,18L21,19C21,20.1,20.1,21,19,21L5,21C3.89,21,3,20.1,3,19L3,5C3,3.9,3.89,3,5,3L19,3C20.1,3,21,3.9,21,5L21,6 12,6C10.89,6,10,6.9,10,8L10,16C10,17.1,10.89,18,12,18L21,18z M12,16L22,16 22,8 12,8 12,16z M16,13.5C15.17,13.5 14.5,12.83 14.5,12 14.5,11.17 15.17,10.5 16,10.5 16.83,10.5 17.5,11.17 17.5,12 17.5,12.83 16.83,13.5 16,13.5z";
                    break;
                case GoogleMaterialIcons.AccountBox:
                    data = "F1 M24,24z M0,0z M3,5L3,19C3,20.1,3.89,21,5,21L19,21C20.1,21,21,20.1,21,19L21,5C21,3.9,20.1,3,19,3L5,3C3.89,3,3,3.9,3,5z M15,9C15,10.66 13.66,12 12,12 10.34,12 9,10.66 9,9 9,7.34 10.34,6 12,6 13.66,6 15,7.34 15,9z M6,17C6,15 10,13.9 12,13.9 14,13.9 18,15 18,17L18,18 6,18 6,17z";
                    break;
                case GoogleMaterialIcons.AccountCircle:
                    data = "F1 M24,24z M0,0z M12,2C6.48,2 2,6.48 2,12 2,17.52 6.48,22 12,22 17.52,22 22,17.52 22,12 22,6.48 17.52,2 12,2z M12,5C13.66,5 15,6.34 15,8 15,9.66 13.66,11 12,11 10.34,11 9,9.66 9,8 9,6.34 10.34,5 12,5z M12,19.2C9.5,19.2 7.29,17.92 6,15.98 6.03,13.99 10,12.9 12,12.9 13.99,12.9 17.97,13.99 18,15.98 16.71,17.92 14.5,19.2 12,19.2z";
                    break;
                case GoogleMaterialIcons.AddShoppingCart:
                    data = "F1 M24,24z M0,0z M11,9L13,9 13,6 16,6 16,4 13,4 13,1 11,1 11,4 8,4 8,6 11,6 11,9z M7,18C5.9,18 5.01,18.9 5.01,20 5.01,21.1 5.9,22 7,22 8.1,22 9,21.1 9,20 9,18.9 8.1,18 7,18z M17,18C15.9,18 15.01,18.9 15.01,20 15.01,21.1 15.9,22 17,22 18.1,22 19,21.1 19,20 19,18.9 18.1,18 17,18z M7.17,14.75L7.2,14.63 8.1,13 15.55,13C16.3,13,16.96,12.59,17.3,11.97L21.16,4.96 19.42,4 19.41,4 18.31,6 15.55,11 8.53,11 8.4,10.73 6.16,6 5.21,4 4.27,2 1,2 1,4 3,4 6.6,11.59 5.25,14.04C5.09,14.32 5,14.65 5,15 5,16.1 5.9,17 7,17L19,17 19,15 7.42,15C7.29,15,7.17,14.89,7.17,14.75z";
                    break;
                case GoogleMaterialIcons.Alarm:
                    data = "F1 M24,24z M0,0z M22,5.72L17.4,1.86 16.11,3.39 20.71,7.25 22,5.72z M7.88,3.39L6.6,1.86 2,5.71 3.29,7.24 7.88,3.39z M12.5,8L11,8 11,14 15.75,16.85 16.5,15.62 12.5,13.25 12.5,8z M12,4C7.03,4 3,8.03 3,13 3,17.97 7.02,22 12,22 16.97,22 21,17.97 21,13 21,8.03 16.97,4 12,4z M12,20C8.13,20 5,16.87 5,13 5,9.13 8.13,6 12,6 15.87,6 19,9.13 19,13 19,16.87 15.87,20 12,20z";
                    break;
                case GoogleMaterialIcons.AlarmAdd:
                    data = "F1 M24,24z M0,0z M7.88,3.39L6.6,1.86 2,5.71 3.29,7.24 7.88,3.39z M22,5.72L17.4,1.86 16.11,3.39 20.71,7.25 22,5.72z M12,4C7.03,4 3,8.03 3,13 3,17.97 7.02,22 12,22 16.97,22 21,17.97 21,13 21,8.03 16.97,4 12,4z M12,20C8.13,20 5,16.87 5,13 5,9.13 8.13,6 12,6 15.87,6 19,9.13 19,13 19,16.87 15.87,20 12,20z M13,9L11,9 11,12 8,12 8,14 11,14 11,17 13,17 13,14 16,14 16,12 13,12 13,9z";
                    break;
                case GoogleMaterialIcons.AlarmOff:
                    data = "F1 M24,24z M0,0z M12,6C15.87,6 19,9.13 19,13 19,13.84 18.84,14.65 18.57,15.4L20.09,16.92C20.67,15.73 21,14.41 21,13 21,8.03 16.97,4 12,4 10.59,4 9.27,4.33 8.08,4.91L9.6,6.43C10.35,6.16,11.16,6,12,6z M22,5.72L17.4,1.86 16.11,3.39 20.71,7.25 22,5.72z M2.92,2.29L1.65,3.57 2.98,4.9 1.87,5.83 3.29,7.25 4.4,6.31 5.2,7.11C3.83,8.69 3,10.75 3,13 3,17.97 7.02,22 12,22 14.25,22 16.31,21.17 17.89,19.8L20.09,22 21.36,20.73 3.89,3.27 2.92,2.29z M16.47,18.39C15.26,19.39 13.7,20 12,20 8.13,20 5,16.87 5,13 5,11.3 5.61,9.74 6.61,8.53L16.47,18.39z M8.02,3.28L6.6,1.86 5.74,2.57 7.16,3.99 8.02,3.28z";
                    break;
                case GoogleMaterialIcons.AlarmOn:
                    data = "F1 M24,24z M0,0z M22,5.72L17.4,1.86 16.11,3.39 20.71,7.25 22,5.72z M7.88,3.39L6.6,1.86 2,5.71 3.29,7.24 7.88,3.39z M12,4C7.03,4 3,8.03 3,13 3,17.97 7.02,22 12,22 16.97,22 21,17.97 21,13 21,8.03 16.97,4 12,4z M12,20C8.13,20 5,16.87 5,13 5,9.13 8.13,6 12,6 15.87,6 19,9.13 19,13 19,16.87 15.87,20 12,20z M10.54,14.53L8.41,12.4 7.35,13.46 10.53,16.64 16.53,10.64 15.47,9.58 10.54,14.53z";
                    break;
                case GoogleMaterialIcons.AllOut:
                    data = "F1 M24,24z M0,0z M16.21,4.16L20.21,8.16 20.21,4.16z M20.21,16.16L16.21,20.16 20.21,20.16z M8.21,20.16L4.21,16.16 4.21,20.16z M4.21,8.16L8.21,4.16 4.21,4.16z M17.16,7.21C14.43,4.48 9.99,4.48 7.26,7.21 4.53,9.94 4.53,14.38 7.26,17.11 9.99,19.84 14.43,19.84 17.16,17.11 19.89,14.38 19.89,9.95 17.16,7.21z M16.06,16.01C13.93,18.14 10.49,18.14 8.36,16.01 6.23,13.88 6.23,10.44 8.36,8.31 10.49,6.18 13.93,6.18 16.06,8.31 18.19,10.44 18.19,13.88 16.06,16.01z";
                    break;
                case GoogleMaterialIcons.Android:
                    data = "F1 M24,24z M0,0z M6,18C6,18.55,6.45,19,7,19L8,19 8,22.5C8,23.33 8.67,24 9.5,24 10.33,24 11,23.33 11,22.5L11,19 13,19 13,22.5C13,23.33 13.67,24 14.5,24 15.33,24 16,23.33 16,22.5L16,19 17,19C17.55,19,18,18.55,18,18L18,8 6,8 6,18z M3.5,8C2.67,8,2,8.67,2,9.5L2,16.5C2,17.33 2.67,18 3.5,18 4.33,18 5,17.33 5,16.5L5,9.5C5,8.67,4.33,8,3.5,8z M20.5,8C19.67,8,19,8.67,19,9.5L19,16.5C19,17.33 19.67,18 20.5,18 21.33,18 22,17.33 22,16.5L22,9.5C22,8.67,21.33,8,20.5,8z M15.53,2.16L16.83,0.86C17.03,0.66 17.03,0.35 16.83,0.15 16.63,-0.0499999999999999 16.32,-0.0499999999999999 16.12,0.15L14.64,1.63C13.85,1.23 12.95,1 12,1 11.04,1 10.14,1.23 9.34,1.63L7.85,0.15C7.65,-0.05 7.34,-0.05 7.14,0.15 6.94,0.35 6.94,0.66 7.14,0.86L8.45,2.17C6.97,3.26,6,5.01,6,7L18,7C18,5.01,17.03,3.25,15.53,2.16z M10,5L9,5 9,4 10,4 10,5z M15,5L14,5 14,4 15,4 15,5z";
                    break;
                case GoogleMaterialIcons.Announcement:
                    data = "F1 M24,24z M0,0z M20,2L4,2C2.9,2,2.01,2.9,2.01,4L2,22 6,18 20,18C21.1,18,22,17.1,22,16L22,4C22,2.9,21.1,2,20,2z M13,11L11,11 11,5 13,5 13,11z M13,15L11,15 11,13 13,13 13,15z";
                    break;
                case GoogleMaterialIcons.AspectRatio:
                    data = "F1 M24,24z M0,0z M19,12L17,12 17,15 14,15 14,17 19,17 19,12z M7,9L10,9 10,7 5,7 5,12 7,12 7,9z M21,3L3,3C1.9,3,1,3.9,1,5L1,19C1,20.1,1.9,21,3,21L21,21C22.1,21,23,20.1,23,19L23,5C23,3.9,22.1,3,21,3z M21,19.01L3,19.01 3,4.99 21,4.99 21,19.01z";
                    break;
                case GoogleMaterialIcons.Assessment:
                    data = "F1 M24,24z M0,0z M19,3L5,3C3.9,3,3,3.9,3,5L3,19C3,20.1,3.9,21,5,21L19,21C20.1,21,21,20.1,21,19L21,5C21,3.9,20.1,3,19,3z M9,17L7,17 7,10 9,10 9,17z M13,17L11,17 11,7 13,7 13,17z M17,17L15,17 15,13 17,13 17,17z";
                    break;
                case GoogleMaterialIcons.AssessmentInd:
                    data = "F1 M24,24z M0,0z M19,3L14.82,3C14.4,1.84 13.3,1 12,1 10.7,1 9.6,1.84 9.18,3L5,3C3.9,3,3,3.9,3,5L3,19C3,20.1,3.9,21,5,21L19,21C20.1,21,21,20.1,21,19L21,5C21,3.9,20.1,3,19,3z M12,3C12.55,3 13,3.45 13,4 13,4.55 12.55,5 12,5 11.45,5 11,4.55 11,4 11,3.45 11.45,3 12,3z M12,7C13.66,7 15,8.34 15,10 15,11.66 13.66,13 12,13 10.34,13 9,11.66 9,10 9,8.34 10.34,7 12,7z M18,19L6,19 6,17.6C6,15.6 10,14.5 12,14.5 14,14.5 18,15.6 18,17.6L18,19z";
                    break;
                case GoogleMaterialIcons.AssessmentLate:
                    data = "F1 M24,24z M0,0z M19,3L14.82,3C14.4,1.84 13.3,1 12,1 10.7,1 9.6,1.84 9.18,3L5,3C3.9,3,3,3.9,3,5L3,19C3,20.1,3.9,21,5,21L19,21C20.1,21,21,20.1,21,19L21,5C21,3.9,20.1,3,19,3z M13,18L11,18 11,16 13,16 13,18z M13,14L11,14 11,8 13,8 13,14z M12,5C11.45,5 11,4.55 11,4 11,3.45 11.45,3 12,3 12.55,3 13,3.45 13,4 13,4.55 12.55,5 12,5z";
                    break;
                case GoogleMaterialIcons.Assignment:
                    data = "F1 M24,24z M0,0z M19,3L14.82,3C14.4,1.84 13.3,1 12,1 10.7,1 9.6,1.84 9.18,3L5,3C3.9,3,3,3.9,3,5L3,19C3,20.1,3.9,21,5,21L19,21C20.1,21,21,20.1,21,19L21,5C21,3.9,20.1,3,19,3z M12,3C12.55,3 13,3.45 13,4 13,4.55 12.55,5 12,5 11.45,5 11,4.55 11,4 11,3.45 11.45,3 12,3z M14,17L7,17 7,15 14,15 14,17z M17,13L7,13 7,11 17,11 17,13z M17,9L7,9 7,7 17,7 17,9z";
                    break;
                case GoogleMaterialIcons.Add:
                    data = "F1 M24,24z M0,0z M19,13L13,13 13,19 11,19 11,13 5,13 5,11 11,11 11,5 13,5 13,11 19,11 19,13z";
                    break;
                case GoogleMaterialIcons.ArrowDownward:
                    data = "F1 M24,24z M0,0z M20,12L18.59,10.59 13,16.17 13,4 11,4 11,16.17 5.42,10.58 4,12 12,20 20,12z";
                    break;
                case GoogleMaterialIcons.ArrowUpward:
                    data = "F1 M24,24z M0,0z M4,12L5.41,13.41 11,7.83 11,20 13,20 13,7.83 18.58,13.42 20,12 12,4 4,12z";
                    break;
                case GoogleMaterialIcons.AttachFile:
                    data = "F1 M24,24z M0,0z M16.5,6L16.5,17.5C16.5,19.71 14.71,21.5 12.5,21.5 10.29,21.5 8.5,19.71 8.5,17.5L8.5,5C8.5,3.62 9.62,2.5 11,2.5 12.38,2.5 13.5,3.62 13.5,5L13.5,15.5C13.5,16.05 13.05,16.5 12.5,16.5 11.95,16.5 11.5,16.05 11.5,15.5L11.5,6 10,6 10,15.5C10,16.88 11.12,18 12.5,18 13.88,18 15,16.88 15,15.5L15,5C15,2.79 13.21,1 11,1 8.79,1 7,2.79 7,5L7,17.5C7,20.54 9.46,23 12.5,23 15.54,23 18,20.54 18,17.5L18,6 16.5,6z";
                    break;
                case GoogleMaterialIcons.AttachMoney:
                    data = "F1 M24,24z M0,0z M11.8,10.9C9.53,10.31 8.8,9.7 8.8,8.75 8.8,7.66 9.81,6.9 11.5,6.9 13.28,6.9 13.94,7.75 14,9L16.21,9C16.14,7.28,15.09,5.7,13,5.19L13,3 10,3 10,5.16C8.06,5.58 6.5,6.84 6.5,8.77 6.5,11.08 8.41,12.23 11.2,12.9 13.7,13.5 14.2,14.38 14.2,15.31 14.2,16 13.71,17.1 11.5,17.1 9.44,17.1 8.63,16.18 8.52,15L6.32,15C6.44,17.19,8.08,18.42,10,18.83L10,21 13,21 13,18.85C14.95,18.48 16.5,17.35 16.5,15.3 16.5,12.46 14.07,11.49 11.8,10.9z";
                    break;
                case GoogleMaterialIcons.BorderColor:
                    data = "F1 M24,24z M0,0z M17.75,7L14,3.25 4,13.25 4,17 7.75,17 17.75,7z M20.71,4.04C21.1,3.65,21.1,3.02,20.71,2.63L18.37,0.29C17.98,-0.1,17.35,-0.1,16.96,0.29L15,2.25 18.75,6 20.71,4.04z M0,20L24,20 24,24 0,24z";
                    break;
                case GoogleMaterialIcons.Clear:
                    data = "F1 M24,24z M0,0z M19,6.41L17.59,5 12,10.59 6.41,5 5,6.41 10.59,12 5,17.59 6.41,19 12,13.41 17.59,19 19,17.59 13.41,12z";
                    break;
                case GoogleMaterialIcons.Code:
                    data = "F1 M24,24z M0,0z M9.4,16.6L4.8,12 9.4,7.4 8,6 2,12 8,18 9.4,16.6z M14.6,16.6L19.2,12 14.6,7.4 16,6 22,12 16,18 14.6,16.6z";
                    break;
                case GoogleMaterialIcons.ContentCopy:
                    data = "F1 M24,24z M0,0z M16,1L4,1C2.9,1,2,1.9,2,3L2,17 4,17 4,3 16,3 16,1z M19,5L8,5C6.9,5,6,5.9,6,7L6,21C6,22.1,6.9,23,8,23L19,23C20.1,23,21,22.1,21,21L21,7C21,5.9,20.1,5,19,5z M19,21L8,21 8,7 19,7 19,21z";
                    break;
                case GoogleMaterialIcons.Delete:
                    data = "F1 M24,24z M0,0z M6,19C6,20.1,6.9,21,8,21L16,21C17.1,21,18,20.1,18,19L18,7 6,7 6,19z M19,4L15.5,4 14.5,3 9.5,3 8.5,4 5,4 5,6 19,6 19,4z";
                    break;
                case GoogleMaterialIcons.DeleteForever:
                    data = "F1 M24,24z M0,0z M6,19C6,20.1,6.9,21,8,21L16,21C17.1,21,18,20.1,18,19L18,7 6,7 6,19z M8.46,11.88L9.87,10.47 12,12.59 14.12,10.47 15.53,11.88 13.41,14 15.53,16.12 14.12,17.53 12,15.41 9.88,17.53 8.47,16.12 10.59,14 8.46,11.88z M15.5,4L14.5,3 9.5,3 8.5,4 5,4 5,6 19,6 19,4z";
                    break;
                case GoogleMaterialIcons.Eject:
                    data = "F1 M24,24z M0,0z M5,17L19,17 19,19 5,19z M12,5L5.33,15 18.67,15z";
                    break;
                case GoogleMaterialIcons.FastForward:
                    data = "F1 M24,24z M0,0z M4,18L12.5,12 4,6 4,18z M13,6L13,18 21.5,12 13,6z";
                    break;
                case GoogleMaterialIcons.FastRewind:
                    data = "F1 M24,24z M0,0z M11,18L11,6 2.5,12 11,18z M11.5,12L20,18 20,6 11.5,12z";
                    break;
                case GoogleMaterialIcons.Fingerprint:
                    data = "F1 M24,24z M0,0z M17.81,4.47C17.73,4.47 17.65,4.45 17.58,4.41 15.66,3.42 14,3 12.01,3 10.03,3 8.15,3.47 6.44,4.41 6.2,4.54 5.9,4.45 5.76,4.21 5.63,3.97 5.72,3.66 5.96,3.53 7.82,2.52 9.86,2 12.01,2 14.14,2 16,2.47 18.04,3.52 18.29,3.65 18.38,3.95 18.25,4.19 18.16,4.37 17.99,4.47 17.81,4.47z M3.5,9.72C3.4,9.72 3.3,9.69 3.21,9.63 2.98,9.47 2.93,9.16 3.09,8.93 4.08,7.53 5.34,6.43 6.84,5.66 9.98,4.04 14,4.03 17.15,5.65 18.65,6.42 19.91,7.51 20.9,8.9 21.06,9.12 21.01,9.44 20.78,9.6 20.55,9.76 20.24,9.71 20.08,9.48 19.18,8.22 18.04,7.23 16.69,6.54 13.82,5.07 10.15,5.07 7.29,6.55 5.93,7.25 4.79,8.25 3.89,9.51 3.81,9.65 3.66,9.72 3.5,9.72z M9.75,21.79C9.62,21.79 9.49,21.74 9.4,21.64 8.53,20.77 8.06,20.21 7.39,19 6.7,17.77 6.34,16.27 6.34,14.66 6.34,11.69 8.88,9.27 12,9.27 15.12,9.27 17.66,11.69 17.66,14.66 17.66,14.94 17.44,15.16 17.16,15.16 16.88,15.16 16.66,14.94 16.66,14.66 16.66,12.24 14.57,10.27 12,10.27 9.43,10.27 7.34,12.24 7.34,14.66 7.34,16.1 7.66,17.43 8.27,18.51 8.91,19.66 9.35,20.15 10.12,20.93 10.31,21.13 10.31,21.44 10.12,21.64 10.01,21.74 9.88,21.79 9.75,21.79z M16.92,19.94C15.73,19.94 14.68,19.64 13.82,19.05 12.33,18.04 11.44,16.4 11.44,14.66 11.44,14.38 11.66,14.16 11.94,14.16 12.22,14.16 12.44,14.38 12.44,14.66 12.44,16.07 13.16,17.4 14.38,18.22 15.09,18.7 15.92,18.93 16.92,18.93 17.16,18.93 17.56,18.9 17.96,18.83 18.23,18.78 18.49,18.96 18.54,19.24 18.59,19.51 18.41,19.77 18.13,19.82 17.56,19.93 17.06,19.94 16.92,19.94z M14.91,22C14.87,22 14.82,21.99 14.78,21.98 13.19,21.54 12.15,20.95 11.06,19.88 9.66,18.49 8.89,16.64 8.89,14.66 8.89,13.04 10.27,11.72 11.97,11.72 13.67,11.72 15.05,13.04 15.05,14.66 15.05,15.73 15.98,16.6 17.13,16.6 18.28,16.6 19.21,15.73 19.21,14.66 19.21,10.89 15.96,7.83 11.96,7.83 9.12,7.83 6.52,9.41 5.35,11.86 4.96,12.67 4.76,13.62 4.76,14.66 4.76,15.44 4.83,16.67 5.43,18.27 5.53,18.53 5.4,18.82 5.14,18.91 4.88,19.01 4.59,18.87 4.5,18.62 4.01,17.31 3.77,16.01 3.77,14.66 3.77,13.46 4,12.37 4.45,11.42 5.78,8.63 8.73,6.82 11.96,6.82 16.51,6.82 20.21,10.33 20.21,14.65 20.21,16.27 18.83,17.59 17.13,17.59 15.43,17.59 14.05,16.27 14.05,14.65 14.05,13.58 13.12,12.71 11.97,12.71 10.82,12.71 9.89,13.58 9.89,14.65 9.89,16.36 10.55,17.96 11.76,19.16 12.71,20.1 13.62,20.62 15.03,21.01 15.3,21.08 15.45,21.36 15.38,21.62 15.33,21.85 15.12,22 14.91,22z";
                    break;
                case GoogleMaterialIcons.FormatColorFill:
                    data = "F1 M24,24z M0,0z M16.56,8.94L7.62,0 6.21,1.41 8.59,3.79 3.44,8.94C2.85,9.53,2.85,10.48,3.44,11.06L8.94,16.56C9.23,16.85 9.62,17 10,17 10.38,17 10.77,16.85 11.06,16.56L16.56,11.06C17.15,10.48,17.15,9.53,16.56,8.94z M5.21,10L10,5.21 14.79,10 5.21,10z M19,11.5C19,11.5 17,13.67 17,15 17,16.1 17.9,17 19,17 20.1,17 21,16.1 21,15 21,13.67 19,11.5 19,11.5z M0,20L24,20 24,24 0,24z";
                    break;
                case GoogleMaterialIcons.Forward5:
                    data = "F1 M24,24z M0,0z M4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13L18,13C18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13 6,9.7 8.7,7 12,7L12,11 17,6 12,1 12,5C7.6,5,4,8.6,4,13z M10.7,13.9L10.9,11.7 13.3,11.7 13.3,12.4 11.6,12.4 11.5,13.3C11.5,13.3 11.6,13.3 11.6,13.2 11.6,13.1 11.7,13.2 11.7,13.1 11.7,13 11.8,13.1 11.9,13.1L12.1,13.1C12.3,13.1 12.5,13.1 12.6,13.2 12.7,13.3 12.9,13.4 13,13.5 13.1,13.6 13.2,13.8 13.3,14 13.4,14.2 13.4,14.4 13.4,14.6 13.4,14.8 13.4,15 13.3,15.1 13.2,15.2 13.2,15.4 13,15.6 12.8,15.8 12.7,15.8 12.5,15.9 12.3,16 12.1,16 11.9,16 11.7,16 11.5,16 11.4,15.9 11.3,15.8 11.1,15.8 10.9,15.7 10.7,15.6 10.7,15.5 10.6,15.3 10.5,15.1 10.5,15 10.5,14.8L11.3,14.8C11.3,15 11.4,15.1 11.5,15.2 11.6,15.3 11.7,15.3 11.9,15.3 12,15.3 12.1,15.3 12.2,15.2L12.4,15C12.4,15,12.5,14.8,12.5,14.7L12.5,14.1 12.4,13.9 12.2,13.7C12.2,13.7,12,13.6,11.9,13.6L11.7,13.6C11.7,13.6 11.6,13.6 11.5,13.7 11.4,13.8 11.4,13.7 11.4,13.8 11.4,13.9 11.3,13.9 11.3,13.9L10.7,13.9z";
                    break;
                case GoogleMaterialIcons.Forward10:
                    data = "F1 M24,24z M0,0z M4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13L18,13C18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13 6,9.7 8.7,7 12,7L12,11 17,6 12,1 12,5C7.6,5,4,8.6,4,13z M10.8,16L10,16 10,12.7 9,13 9,12.3 10.8,11.7 10.9,11.7 10.9,16z M15.1,14.2C15.1,14.5,15.1,14.8,15,15L14.7,15.6C14.7,15.6 14.4,15.9 14.2,15.9 14,15.9 13.8,16 13.6,16 13.4,16 13.2,16 13,15.9 12.8,15.8 12.7,15.7 12.5,15.6 12.3,15.5 12.3,15.3 12.2,15 12.1,14.7 12.1,14.5 12.1,14.2L12.1,13.5C12.1,13.2,12.1,12.9,12.2,12.7L12.5,12.1C12.5,12.1 12.8,11.8 13,11.8 13.2,11.8 13.4,11.7 13.6,11.7 13.8,11.7 14,11.7 14.2,11.8 14.4,11.9 14.5,12 14.7,12.1 14.9,12.2 14.9,12.4 15,12.7 15.1,13 15.1,13.2 15.1,13.5L15.1,14.2z M14.3,13.4L14.3,12.9C14.3,12.9 14.2,12.7 14.2,12.6 14.2,12.5 14.1,12.5 14,12.4 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.3 13.5,12.3 13.4,12.4L13.2,12.6C13.2,12.6,13.1,12.8,13.1,12.9L13.1,14.9C13.1,14.9 13.2,15.1 13.2,15.2 13.2,15.3 13.3,15.3 13.4,15.4 13.5,15.5 13.6,15.5 13.7,15.5 13.8,15.5 13.9,15.5 14,15.4L14.2,15.2C14.2,15.2,14.3,15,14.3,14.9L14.3,13.4z";
                    break;
                case GoogleMaterialIcons.Forward30:
                    data = "F1 M24,24z M0,0z M9.6,13.5L10,13.5C10.2,13.5 10.4,13.4 10.5,13.3 10.6,13.2 10.7,13.1 10.7,12.9L10.7,12.7C10.7,12.7 10.6,12.6 10.6,12.5 10.6,12.4 10.5,12.4 10.4,12.4L9.9,12.4C9.9,12.4 9.8,12.5 9.7,12.5 9.6,12.5 9.6,12.6 9.6,12.7L9.6,12.9 8.6,12.9C8.6,12.7 8.6,12.6 8.7,12.4 8.8,12.2 8.9,12.1 9,12 9.1,11.9 9.3,11.8 9.4,11.8 9.5,11.8 9.8,11.7 9.9,11.7 10.1,11.7 10.3,11.7 10.5,11.8 10.7,11.9 10.8,11.9 11,12 11.2,12.1 11.2,12.2 11.3,12.4 11.4,12.6 11.4,12.7 11.4,12.9L11.4,13.2C11.4,13.2 11.3,13.4 11.3,13.5 11.3,13.6 11.2,13.7 11.1,13.7 11,13.7 10.9,13.8 10.8,13.9 11,14 11.2,14.1 11.3,14.3 11.4,14.5 11.5,14.7 11.5,14.9 11.5,15.1 11.5,15.3 11.4,15.4 11.3,15.5 11.2,15.7 11.1,15.8 11,15.9 10.8,16 10.6,16 10.4,16 10.2,16.1 10,16.1 9.8,16.1 9.6,16.1 9.5,16 9.4,15.9 9.2,15.9 9,15.8 8.8,15.7 8.8,15.6 8.7,15.4 8.6,15.2 8.6,15 8.6,14.8L9.4,14.8 9.4,15C9.4,15 9.5,15.1 9.5,15.2 9.5,15.3 9.6,15.3 9.7,15.3L10.2,15.3C10.2,15.3 10.3,15.2 10.4,15.2 10.5,15.2 10.5,15.1 10.5,15L10.5,14.5C10.5,14.5 10.4,14.4 10.4,14.3 10.4,14.2 10.3,14.2 10.2,14.2L9.6,14.2 9.6,13.5z M15.3,14.2C15.3,14.5,15.3,14.8,15.2,15L14.9,15.6C14.9,15.6 14.6,15.9 14.4,15.9 14.2,15.9 14,16 13.8,16 13.6,16 13.4,16 13.2,15.9 13,15.8 12.9,15.7 12.7,15.6 12.5,15.5 12.5,15.3 12.4,15 12.3,14.7 12.3,14.5 12.3,14.2L12.3,13.5C12.3,13.2,12.3,12.9,12.4,12.7L12.7,12.1C12.7,12.1 13,11.8 13.2,11.8 13.4,11.8 13.6,11.7 13.8,11.7 14,11.7 14.2,11.7 14.4,11.8 14.6,11.9 14.7,12 14.9,12.1 15.1,12.2 15.1,12.4 15.2,12.7 15.3,13 15.3,13.2 15.3,13.5L15.3,14.2z M14.4,13.4L14.4,12.9C14.4,12.9 14.3,12.7 14.3,12.6 14.3,12.5 14.2,12.5 14.1,12.4 14,12.3 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.3 13.5,12.4L13.3,12.6C13.3,12.6,13.2,12.8,13.2,12.9L13.2,14.9C13.2,14.9 13.3,15.1 13.3,15.2 13.3,15.3 13.4,15.3 13.5,15.4 13.6,15.5 13.7,15.5 13.8,15.5 13.9,15.5 14,15.5 14.1,15.4L14.3,15.2C14.3,15.2,14.4,15,14.4,14.9L14.4,13.4z M4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13L18,13C18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13 6,9.7 8.7,7 12,7L12,11 17,6 12,1 12,5C7.6,5,4,8.6,4,13z";
                    break;
                case GoogleMaterialIcons.Fullscreen:
                    data = "F1 M24,24z M0,0z M7,14L5,14 5,19 10,19 10,17 7,17 7,14z M5,10L7,10 7,7 10,7 10,5 5,5 5,10z M17,17L14,17 14,19 19,19 19,14 17,14 17,17z M14,5L14,7 17,7 17,10 19,10 19,5 14,5z";
                    break;
                case GoogleMaterialIcons.KeyboardArrowDown:
                    data = "F1 M24,24z M0,0z M7.41,7.84L12,12.42 16.59,7.84 18,9.25 12,15.25 6,9.25z";
                    break;
                case GoogleMaterialIcons.KeyboardArrowUp:
                    data = "F1 M24,24z M0,0z M7.41,15.41L12,10.83 16.59,15.41 18,14 12,8 6,14z";
                    break;
                case GoogleMaterialIcons.Pause:
                    data = "F1 M24,24z M0,0z M6,19L10,19 10,5 6,5 6,19z M14,5L14,19 18,19 18,5 14,5z";
                    break;
                case GoogleMaterialIcons.PlayArrow:
                    data = "F1 M24,24z M0,0z M8,5L8,19 19,12z";
                    break;
                case GoogleMaterialIcons.Replay:
                    data = "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.31,7 18,9.69 18,13 18,16.31 15.31,19 12,19 8.69,19 6,16.31 6,13L4,13C4,17.42 7.58,21 12,21 16.42,21 20,17.42 20,13 20,8.58 16.42,5 12,5z";
                    break;
                case GoogleMaterialIcons.Replay5:
                    data = "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.3,7 18,9.7 18,13 18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13L4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13 20,8.6 16.4,5 12,5z M10.7,13.9L10.9,11.7 13.3,11.7 13.3,12.4 11.6,12.4 11.5,13.3C11.5,13.3 11.6,13.3 11.6,13.2 11.6,13.1 11.7,13.2 11.7,13.1 11.7,13 11.8,13.1 11.9,13.1L12.1,13.1C12.3,13.1 12.5,13.1 12.6,13.2 12.7,13.3 12.9,13.4 13,13.5 13.1,13.6 13.2,13.8 13.3,14 13.4,14.2 13.4,14.4 13.4,14.6 13.4,14.8 13.4,15 13.3,15.1 13.2,15.2 13.2,15.4 13,15.6 12.8,15.8 12.7,15.8 12.6,15.9 12.5,16 12.2,16 12,16 11.8,16 11.6,16 11.5,15.9 11.4,15.8 11.2,15.8 11,15.7 10.8,15.6 10.8,15.5 10.7,15.3 10.6,15.1 10.6,15 10.6,14.8L11.4,14.8C11.4,15 11.5,15.1 11.6,15.2 11.7,15.3 11.8,15.3 12,15.3 12.1,15.3 12.2,15.3 12.3,15.2L12.5,15C12.5,15,12.6,14.8,12.6,14.7L12.6,14.1 12.5,13.9 12.3,13.7C12.3,13.7,12.1,13.6,12,13.6L11.8,13.6C11.8,13.6 11.7,13.6 11.6,13.7 11.5,13.8 11.5,13.7 11.5,13.8 11.5,13.9 11.4,13.9 11.4,13.9L10.7,13.9z";
                    break;
                case GoogleMaterialIcons.Replay10:
                    data = "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.3,7 18,9.7 18,13 18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13L4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13 20,8.6 16.4,5 12,5z M10.9,16L10,16 10,12.7 9,13 9,12.3 10.8,11.7 10.9,11.7 10.9,16z M15.2,14.2C15.2,14.5,15.2,14.8,15.1,15L14.8,15.6C14.8,15.6 14.5,15.9 14.3,15.9 14.1,15.9 13.9,16 13.7,16 13.5,16 13.3,16 13.1,15.9 12.9,15.8 12.8,15.7 12.6,15.6 12.4,15.5 12.4,15.3 12.3,15 12.2,14.7 12.2,14.5 12.2,14.2L12.2,13.5C12.2,13.2,12.2,12.9,12.3,12.7L12.6,12.1C12.6,12.1 12.9,11.8 13.1,11.8 13.3,11.8 13.5,11.7 13.7,11.7 13.9,11.7 14.1,11.7 14.3,11.8 14.5,11.9 14.6,12 14.8,12.1 15,12.2 15,12.4 15.1,12.7 15.2,13 15.2,13.2 15.2,13.5L15.2,14.2z M14.3,13.4L14.3,12.9C14.3,12.9 14.2,12.7 14.2,12.6 14.2,12.5 14.1,12.5 14,12.4 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.3 13.5,12.3 13.4,12.4L13.2,12.6C13.2,12.6,13.1,12.8,13.1,12.9L13.1,14.9C13.1,14.9 13.2,15.1 13.2,15.2 13.2,15.3 13.3,15.3 13.4,15.4 13.5,15.5 13.6,15.5 13.7,15.5 13.8,15.5 13.9,15.5 14,15.4L14.2,15.2C14.2,15.2,14.3,15,14.3,14.9L14.3,13.4z";
                    break;
                case GoogleMaterialIcons.Replay30:
                    data = "F1 M24,24z M0,0z M12,5L12,1 7,6 12,11 12,7C15.3,7 18,9.7 18,13 18,16.3 15.3,19 12,19 8.7,19 6,16.3 6,13L4,13C4,17.4 7.6,21 12,21 16.4,21 20,17.4 20,13 20,8.6 16.4,5 12,5z M9.6,13.5L10,13.5C10.2,13.5 10.4,13.4 10.5,13.3 10.6,13.2 10.7,13.1 10.7,12.9L10.7,12.7C10.7,12.7 10.6,12.6 10.6,12.5 10.6,12.4 10.5,12.4 10.4,12.4L9.9,12.4C9.9,12.4 9.8,12.5 9.7,12.5 9.6,12.5 9.6,12.6 9.6,12.7L9.6,12.9 8.6,12.9C8.6,12.7 8.6,12.6 8.7,12.4 8.8,12.2 8.9,12.1 9,12 9.1,11.9 9.3,11.8 9.4,11.8 9.5,11.8 9.8,11.7 9.9,11.7 10.1,11.7 10.3,11.7 10.5,11.8 10.7,11.9 10.8,11.9 11,12 11.2,12.1 11.2,12.2 11.3,12.4 11.4,12.6 11.4,12.7 11.4,12.9L11.4,13.2C11.4,13.2 11.3,13.4 11.3,13.5 11.3,13.6 11.2,13.7 11.1,13.7 11,13.7 10.9,13.8 10.8,13.9 11,14 11.2,14.1 11.3,14.3 11.4,14.5 11.5,14.7 11.5,14.9 11.5,15.1 11.5,15.3 11.4,15.4 11.3,15.5 11.2,15.7 11.1,15.8 11,15.9 10.8,16 10.6,16 10.4,16 10.2,16.1 10,16.1 9.8,16.1 9.6,16.1 9.5,16 9.4,15.9 9.2,15.9 9,15.8 8.8,15.7 8.8,15.6 8.7,15.4 8.6,15.2 8.6,15 8.6,14.8L9.4,14.8 9.4,15C9.4,15 9.5,15.1 9.5,15.2 9.5,15.3 9.6,15.3 9.7,15.3L10.2,15.3C10.2,15.3 10.3,15.2 10.4,15.2 10.5,15.2 10.5,15.1 10.5,15L10.5,14.5C10.5,14.5 10.4,14.4 10.4,14.3 10.4,14.2 10.3,14.2 10.2,14.2L9.6,14.2 9.6,13.5z M15.3,14.2C15.3,14.5,15.3,14.8,15.2,15L14.9,15.6C14.9,15.6 14.6,15.9 14.4,15.9 14.2,15.9 14,16 13.8,16 13.6,16 13.4,16 13.2,15.9 13,15.8 12.9,15.7 12.7,15.6 12.5,15.5 12.5,15.3 12.4,15 12.3,14.7 12.3,14.5 12.3,14.2L12.3,13.5C12.3,13.2,12.3,12.9,12.4,12.7L12.7,12.1C12.7,12.1 13,11.8 13.2,11.8 13.4,11.8 13.6,11.7 13.8,11.7 14,11.7 14.2,11.7 14.4,11.8 14.6,11.9 14.7,12 14.9,12.1 15.1,12.2 15.1,12.4 15.2,12.7 15.3,13 15.3,13.2 15.3,13.5L15.3,14.2z M14.5,13.4L14.5,12.9C14.5,12.8 14.4,12.7 14.4,12.6 14.4,12.5 14.3,12.5 14.2,12.4 14.1,12.3 14,12.3 13.9,12.3 13.8,12.3 13.7,12.3 13.6,12.4L13.4,12.6C13.4,12.6,13.3,12.8,13.3,12.9L13.3,14.9C13.3,14.9 13.4,15.1 13.4,15.2 13.4,15.3 13.5,15.3 13.6,15.4 13.7,15.5 13.8,15.5 13.9,15.5 14,15.5 14.1,15.5 14.2,15.4L14.4,15.2C14.4,15.2,14.5,15,14.5,14.9L14.5,13.4z";
                    break;
                case GoogleMaterialIcons.Reply:
                    data = "F1 M24,24z M0,0z M10,9L10,5 3,12 10,19 10,14.9C15,14.9 18.5,16.5 21,20 20,15 17,10 10,9z";
                    break;
                case GoogleMaterialIcons.ReplyAll:
                    data = "F1 M24,24z M0,0z M7,8L7,5 0,12 7,19 7,16 3,12 7,8z M13,9L13,5 6,12 13,19 13,14.9C18,14.9 21.5,16.5 24,20 23,15 20,10 13,9z";
                    break;
                case GoogleMaterialIcons.RotateLeft:
                    data = "F1 M24,24z M0,0z M7.11,8.53L5.7,7.11C4.8,8.27,4.24,9.61,4.07,11L6.09,11C6.23,10.13,6.58,9.28,7.11,8.53z M6.09,13L4.07,13C4.24,14.39,4.79,15.73,5.69,16.89L7.1,15.47C6.58,14.72,6.23,13.88,6.09,13z M7.1,18.32C8.26,19.22,9.61,19.76,11,19.93L11,17.9C10.13,17.75,9.29,17.41,8.54,16.87L7.1,18.32z M13,4.07L13,1 8.45,5.55 13,10 13,6.09C15.84,6.57 18,9.03 18,12 18,14.97 15.84,17.43 13,17.91L13,19.93C16.95,19.44 20,16.08 20,12 20,7.92 16.95,4.56 13,4.07z";
                    break;
                case GoogleMaterialIcons.RotateRight:
                    data = "F1 M24,24z M0,0z M15.55,5.55L11,1 11,4.07C7.06,4.56 4,7.92 4,12 4,16.08 7.05,19.44 11,19.93L11,17.91C8.16,17.43 6,14.97 6,12 6,9.03 8.16,6.57 11,6.09L11,10 15.55,5.55z M19.93,11C19.76,9.61,19.21,8.27,18.31,7.11L16.89,8.53C17.43,9.28,17.77,10.13,17.91,11L19.93,11z M13,17.9L13,19.92C14.39,19.75,15.74,19.21,16.9,18.31L15.46,16.87C14.71,17.41,13.87,17.76,13,17.9z M16.89,15.48L18.31,16.89C19.21,15.73,19.76,14.39,19.93,13L17.91,13C17.77,13.87,17.43,14.72,16.89,15.48z";
                    break;
                case GoogleMaterialIcons.Settings:
                    data = "F1 M24,24z M0,0z M12,15.5A3.5,3.5 0 0,1 8.5,12A3.5,3.5 0 0,1 12,8.5A3.5,3.5 0 0,1 15.5,12A3.5,3.5 0 0,1 12,15.5M19.43,12.97C19.47,12.65 19.5,12.33 19.5,12C19.5,11.67 19.47,11.34 19.43,11L21.54,9.37C21.73,9.22 21.78,8.95 21.66,8.73L19.66,5.27C19.54,5.05 19.27,4.96 19.05,5.05L16.56,6.05C16.04,5.66 15.5,5.32 14.87,5.07L14.5,2.42C14.46,2.18 14.25,2 14,2H10C9.75,2 9.54,2.18 9.5,2.42L9.13,5.07C8.5,5.32 7.96,5.66 7.44,6.05L4.95,5.05C4.73,4.96 4.46,5.05 4.34,5.27L2.34,8.73C2.21,8.95 2.27,9.22 2.46,9.37L4.57,11C4.53,11.34 4.5,11.67 4.5,12C4.5,12.33 4.53,12.65 4.57,12.97L2.46,14.63C2.27,14.78 2.21,15.05 2.34,15.27L4.34,18.73C4.46,18.95 4.73,19.03 4.95,18.95L7.44,17.94C7.96,18.34 8.5,18.68 9.13,18.93L9.5,21.58C9.54,21.82 9.75,22 10,22H14C14.25,22 14.46,21.82 14.5,21.58L14.87,18.93C15.5,18.67 16.04,18.34 16.56,17.94L19.05,18.95C19.27,19.03 19.54,18.95 19.66,18.73L21.66,15.27C21.78,15.05 21.73,14.78 21.54,14.63L19.43,12.97Z";
                    break;
                case GoogleMaterialIcons.SkipNext:
                    data = "F1 M24,24z M0,0z M6,18L14.5,12 6,6 6,18z M16,6L16,18 18,18 18,6 16,6z";
                    break;
                case GoogleMaterialIcons.SkipPrevious:
                    data = "F1 M24,24z M0,0z M6,6L8,6 8,18 6,18z M9.5,12L18,18 18,6z";
                    break;
                case GoogleMaterialIcons.Speaker:
                    data = "M12,12A3,3 0 0,0 9,15A3,3 0 0,0 12,18A3,3 0 0,0 15,15A3,3 0 0,0 12,12M12,20A5,5 0 0,1 7,15A5,5 0 0,1 12,10A5,5 0 0,1 17,15A5,5 0 0,1 12,20M12,4A2,2 0 0,1 14,6A2,2 0 0,1 12,8C10.89,8 10,7.1 10,6C10,4.89 10.89,4 12,4M17,2H7C5.89,2 5,2.89 5,4V20A2,2 0 0,0 7,22H17A2,2 0 0,0 19,20V4C19,2.89 18.1,2 17,2Z";
                    break;
                case GoogleMaterialIcons.StarHalf:
                    data = "F1 M24,24z M0,0z M22,9.24L14.81,8.62 12,2 9.19,8.63 2,9.24 7.46,13.97 5.82,21 12,17.27 18.18,21 16.55,13.97 22,9.24z M12,15.4L12,6.1 13.71,10.14 18.09,10.52 14.77,13.4 15.77,17.68 12,15.4z";
                    break;
                case GoogleMaterialIcons.Stop:
                    data = "F1 M24,24z M0,0z M6,6L18,6 18,18 6,18z";
                    break;
                case GoogleMaterialIcons.Swaphoriz:
                    data = "F1 M24,24z M0,0z M6.99,11L3,15 6.99,19 6.99,16 14,16 14,14 6.99,14 6.99,11z M21,9L17.01,5 17.01,8 10,8 10,10 17.01,10 17.01,13 21,9z";
                    break;
                case GoogleMaterialIcons.Weekend:
                    data = "F1 M24,24z M0,0z M21,10C19.9,10,19,10.9,19,12L19,15 5,15 5,12C5,10.9 4.1,10 3,10 1.9,10 1,10.9 1,12L1,17C1,18.1,1.9,19,3,19L21,19C22.1,19,23,18.1,23,17L23,12C23,10.9,22.1,10,21,10z M18,5L6,5C4.9,5,4,5.9,4,7L4,9.15C5.16,9.56,6,10.66,6,11.97L6,14 18,14 18,11.97C18,10.67,18.84,9.57,20,9.15L20,7C20,5.9,19.1,5,18,5z";
                    break;
                case GoogleMaterialIcons.Wrench:
                    data = " M24,24z M0,0z M22.7,19L13.6,9.9C14.5,7.6 14,4.9 12.1,3C10.1,1 7.1,0.6 4.7,1.7L9,6L6,9L1.6,4.7C0.4,7.1 0.9,10.1 2.9,12.1C4.8,14 7.5,14.5 9.8,13.6L18.9,22.7C19.3,23.1 19.9,23.1 20.3,22.7L22.6,20.4C23.1,20 23.1,19.3 22.7,19Z";
                    break;
                case GoogleMaterialIcons.YouTubePlay:
                    data = " M24,24z M0,0z M10,16.5V7.5L16,12M20,4.4C19.4,4.2 15.7,4 12,4C8.3,4 4.6,4.19 4,4.38C2.44,4.9 2,8.4 2,12C2,15.59 2.44,19.1 4,19.61C4.6,19.81 8.3,20 12,20C15.7,20 19.4,19.81 20,19.61C21.56,19.1 22,15.59 22,12C22,8.4 21.56,4.91 20,4.4Z";
                    break;
                case GoogleMaterialIcons.ZipBox:
                    data = " M24,24z M0,0z M14,17H12V15H10V13H12V15H14M14,9H12V11H14V13H12V11H10V9H12V7H10V5H12V7H14M19,3H5C3.89,3 3,3.89 3,5V19A2,2 0 0,0 5,21H19A2,2 0 0,0 21,19V5C21,3.89 20.1,3 19,3Z";
                    break;

                default:
                    data = "";
                    break;
            }

            return data;
        }
    }
}

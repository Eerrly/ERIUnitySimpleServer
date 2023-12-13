﻿namespace ERIUnitySimpleServer
{
    public class NetConstant
    {
        public static readonly string IP = "127.0.0.1";

        public static readonly int Port = 10086;

        public static readonly int FrameInterval = 33;

    	/// <summary>
    	/// 帧数据命令
    	/// </summary>
        public const int pvpFrameCmd = 4;
        public const int pvpReadyAct = 3;
        public const int pvpFrameAct = 2;
        public const int pvpPingAct = 1;
    }
}

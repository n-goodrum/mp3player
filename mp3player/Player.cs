using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace mp3player
{
    internal class Player
    {
        [DllImport("winmm.dll")]

        private static extern long mciSendString(string comStr, StringBuilder retStr, int retLen, int callBack);

        public void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
        }

        public void play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);

        }
        public void pause()
        {
            string command = "pause MediaFile";
            mciSendString(command, null, 0, 0);

        }
    }
}

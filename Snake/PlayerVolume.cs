using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace VolumeControl
{
   public class PlayerVolume 
   {
      [DllImport("winmm.dll")]
      public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

      [DllImport("winmm.dll")]
      public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

      public PlayerVolume(int volume)
      {
         // By the default set the volume to 0
         uint CurrVol = 0;
         // At this point, CurrVol gets assigned the volume
         waveOutGetVolume(IntPtr.Zero, out CurrVol);
         // Calculate the volume
         ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
         // Get the volume on a scale of 1 to 10 (to fit the trackbar)
         volume = CalcVol / (ushort.MaxValue / 10);
      }

      
   }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace CriptograficiaPontaAPonta
{
    public class BuscaSerialHD
    {
        public static string GetHDDSerialNumber()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT SerialNumber FROM Win32_DiskDrive WHERE InterfaceType='IDE' OR InterfaceType='SCSI'");
            ManagementObjectCollection drives = searcher.Get();

            foreach (ManagementObject drive in drives)
            {
                string serialNumber = drive["SerialNumber"].ToString().Trim();
                if (!string.IsNullOrEmpty(serialNumber))
                {
                    return serialNumber;
                }
            }
            return string.Empty;
        }
    }    
}

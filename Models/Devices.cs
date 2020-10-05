using System;
using System.ComponentModel.DataAnnotations;
using MvcDevices.Data;
using IPGeolocation;

namespace MvcDevices.Models
{
    public class Devices
    {
        [Key]
        public int AssetID { get; set; }
        public string AssetName { get; set; }
        public string PublicIP { get; set; }
        public string PrivateIP { get; set; }
        public bool ConnectionStatus { get; set; }
        public int PrivilegeID { get; set; }
        public string Hostname { get; set; }
        public int ProjectID { get; set; }
    }
}
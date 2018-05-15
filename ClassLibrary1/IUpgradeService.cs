using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IUpgradeService
    {
        int currentSWVersion(int x);
        bool isSWUpgradeRequired(int DeviceID);
        DateTime lastUpgradeDate(int DeviceID);
        bool upgradeDevice(int DeviceID);
    }
}

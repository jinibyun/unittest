using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UpgradeService : IUpgradeService
    {
        public int currentSWVersion(int x)
        {
            return 5;
        }

        public bool isSWUpgradeRequired(int DeviceID)
        {
            throw new NotImplementedException();
        }

        public DateTime lastUpgradeDate(int DeviceID)
        {
            throw new NotImplementedException();
        }

        public bool upgradeDevice(int DeviceID)
        {
            throw new NotImplementedException();
        }
    }
}

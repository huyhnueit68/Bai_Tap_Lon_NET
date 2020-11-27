using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Controller
{
    class RentDeviceCtrl
    {
        Model.RentDeviceManage rentDeviceMng = new Model.RentDeviceManage();
        public int Update(Object.ObjRentDevice rentDevice)
        {
            return rentDeviceMng.Update(rentDevice);
        }

        public int PayDevice(Object.ObjRentDevice rentDevice)
        {
            return rentDeviceMng.PayDevice(rentDevice);
        }
    }
}

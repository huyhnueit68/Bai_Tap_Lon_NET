using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Object
{
    class ObjDevice
    {
        private string _idDevice;

        public string Id_Device
        {
            get { return _idDevice; }
            set { _idDevice = value; }
        }

        private string _nameDevice;

        public string Name_Device
        {
            get { return _nameDevice; }
            set { _nameDevice = value; }
        }

        private string _qtyDevice;

        public string Qty_Device
        {
            get { return _qtyDevice; }
            set { _qtyDevice = value; }
        }

        private string _price;

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _functionDevice;

        public string Function_Device
        {
            get { return _functionDevice; }
            set { _functionDevice = value; }
        }

        private string _room;

        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }

        private string _idType;

        public string Id_Type
        {
            get { return _idType; }
            set { _idType = value; }
        }

        private string _statusDevice;

        public string Status_Device
        {
            get { return _statusDevice; }
            set { _statusDevice = value; }
        }
    }
}

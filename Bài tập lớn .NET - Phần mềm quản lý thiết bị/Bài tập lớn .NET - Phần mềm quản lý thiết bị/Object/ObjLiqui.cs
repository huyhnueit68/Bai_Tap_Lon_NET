using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Object
{
    class ObjLiqui
    {
        private string _idLiqui;

        public string Id_Liqui
        {
            get { return _idLiqui; }
            set { _idLiqui = value; }
        }

        private string _nameLiqui;

        public string Name_Liqui
        {
            get { return _nameLiqui; }
            set { _nameLiqui = value; }
        }

        private string _idDevice;

        public string Id_Device
        {
            get { return _idDevice; }
            set { _idDevice = value; }
        }

        private string _qtyDevice;

        public string Qty_Device
        {
            get { return _qtyDevice; }
            set { _qtyDevice = value; }
        }

        private string _dateLiqui;

        public string Date_Liqui
        {
            get { return _dateLiqui; }
            set { _dateLiqui = value; }
        }
    }
}

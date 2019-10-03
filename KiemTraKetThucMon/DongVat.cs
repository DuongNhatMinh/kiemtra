using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KiemTraKetThucMon
{
    class DongVat
    {
        private string Keu;

        public string tiengkeu
        {
            get { return Keu; }
            set { Keu = value; }
        }

        public DongVat(string stKeu)
        {
            this.Keu = stKeu;
        }

        public DongVat()
        {
        }

        private string MauLong;

        public string DongvatMauLong
        {
            get
            {
                return MauLong;
            }
            set
            {
                MauLong = value;
            }
        }

        public string Dongvat { get; private set; }

        public virtual void Talk()
        {
            if (tiengkeu.Equals("Gâu gâu") && (DongvatMauLong.Equals("Trắng")))
                MessageBox.Show(this.Dongvat + " Tôi là chó lông màu: " + this.DongvatMauLong);
            else if (tiengkeu.Equals("Meo meo") && (DongvatMauLong.Equals("Đen")))
                MessageBox.Show(this.Dongvat + " Tôi là mèo lông màu: " + this.DongvatMauLong);
        }
    }
}


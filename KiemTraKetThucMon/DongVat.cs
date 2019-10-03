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

        public string MauLong
        {
            get { return MauLong; }
            set { MauLong = value; }
        }

        public virtual void Talk()
        {
            if (tiengkeu.Equals("Gau gau"))
                MessageBox.Show("Cho keu: " + this.tiengkeu);
            else if (tiengkeu.Equals("Meo meo"))
                MessageBox.Show("Meo keu: " + this.tiengkeu);
        }
    }
}


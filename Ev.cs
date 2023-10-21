using System;

namespace EvLibrary
{
    public class Ev
    {

        public Ev()
        {

        }
        public  Ev(int odasayisi,int katno,double alan, string semt)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Alan = alan;
            this.Semt = semt;
            
        }

        int odasayisi;
        double alan;
        string semt;
        int katno;

        public int Odasayisi { get => odasayisi; set => odasayisi =Math.Abs( value); }
        public double Alan { get => alan; set => alan = value; }
        public string Semt { get => semt; set => semt = value.ToUpper(); }
        public int Katno { get => katno; set => katno = value; }

        public string EvBilgileri()
        {
            return ( $"Oda sayisi:{this.Odasayisi}\nKat no:{this.Katno}\nSemt:{this.Semt}\nAlan:{this.Alan}");

        }

    }
}
//internal:Aynı assembly içindeki classlar tarafından erişebilir.
//Erişim belirleyiciler/Access Modifiers
//private:gizli 
//İnternal:
//Protected:nesne referansları ile erişilmesinin önüne geçer
//public:heerkese açık
//sealed:miras alınamıyor
//çok biçimlilik
//interface:
//abstraction:detayları saklama ve sadece gösterilmesi istenen bilgileri kullanıcıya göstermek amacıyla kullanılır.
//polymorphisim:
//dispose:garbage collectorun silemediklerini siliyor.
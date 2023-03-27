using DLWMS.Data.IspitIB200199;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace DLWMS.Data
{
    [Table("Studenti")]
    public class Student
    {
        DLWMSDbContext baza = KonekcijaNaBazu.Baza;
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int GodinaStudija { get; set; }
        public byte[] Slika { get; set; }
        public bool Aktivan { get; set; }
        public Spol Spol { get; set; }       

        public override string ToString()
        {
            return $" {Ime} {Prezime}";
        }
        [NotMapped]
        public string ImePrezime => $"{Ime} {Prezime}";
        [NotMapped]
        public int BrojPolozenih => baza.StudentiPredmeti.Where(x => x.Student.Id == Id).Count();

    }  
}
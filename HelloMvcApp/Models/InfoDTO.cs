namespace HelloMvcApp.Models
{
    public class InfoDTO
    {
        public InfoDTO()
        {

        }
        public InfoDTO(Ogrenci ogrenci,Ogretmen ogretmen)
        {
            this.Ogrenci = ogrenci;
            this.Ogretmen = ogretmen;   
        }
        public Ogrenci Ogrenci { get; set; }
        public Ogretmen Ogretmen { get; set; }
    }
}

//DTO: Data Transfer Object

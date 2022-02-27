using System;
using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class CustomerViewModel
    {
        [Key] //Primary key olarak kullanılacak
        public int Id { get; set; }
        public int Age { get; set; }

        [Required(ErrorMessage = "Ad Alanı zorunlu alandır")]
        [StringLength(10, ErrorMessage ="10 Karakterden büyük olamaz.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyadı Alanı zorunlu alandır")]
        [StringLength(10, ErrorMessage = "10 Karakterden büyük olamaz.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Adres Alanı zorunlu alandır")]
        [StringLength(100, ErrorMessage = "100 Karakterden büyük olamaz.")]
        public string Adress { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Password)]
        public int Password { get; set; }


        //public CustomerViewModel()
        //{
        //    Id = Guid.NewGuid();
        //}

        //Guid : benzersiz kimlik, dünya üzerinde yok 

        //public DateTime BirtDate { get; set; }

        //private DateTime _birthDate;
        //[Display(Name = "Yaş")]
        //public DateTime BirtDate
        //{
        //    get { return _birthDate; }
        //    set
        //    {
        //        if (value.Year < 1970)
        //        {
        //            Description = "Müşteri dogum tarihi 1970'den büyük";
        //        }
        //        _birthDate = value;
        //    }
        //}

    }
}

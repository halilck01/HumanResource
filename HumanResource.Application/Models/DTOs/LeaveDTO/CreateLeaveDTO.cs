﻿using System.ComponentModel.DataAnnotations;

namespace HumanResource.Application.Models.DTOs.LeaveDTO
{
    public class CreateLeaveDTO
    {
        public Guid UserId { get; set; }
        public DateTime CreatedDate => DateTime.Now;

        [Required(ErrorMessage = "Başlangıç Tarihi Boş Geçilemez.")]
        [Display(Name = "İzin Başlangıç Tarihi")]
        [DataType(DataType.Date)]

        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Bitiş Tarihi Boş Geçilemez.")]
        [Display(Name = "İzin Bitiş Tarihi")]
        [DataType(DataType.Date)]
        

        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "İşe dönüş Tarihi Boş Geçilemez.")]
        [Display(Name = "İşe Dönüş tarihi")]
        [DataType(DataType.Date)]

        public DateTime ReturnDate { get; set; }

        [Required(ErrorMessage = "İzin Türü Boş Geçilemez.")]
        [Display(Name = "İzin Türü")]
        public int LeaveTypeId { get; set; }

        //public Statu Statu { get; set; }

        //ToDo: Tarih aralığı için attribute yazılacak
    }
}

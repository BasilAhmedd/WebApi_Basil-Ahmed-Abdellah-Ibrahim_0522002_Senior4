﻿using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.DTOs.DirectorDTOs;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Repo.DirectorRepo
{
    public interface IDirectoryRepo
    {
        void AddDirectory(Director_Add_Update_DTO dto);
        void UpdateDirectory(Director_Add_Update_DTO dto,int id);
        void DeleteDirectory(int id);
    }
}

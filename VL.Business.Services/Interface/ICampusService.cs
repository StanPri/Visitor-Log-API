﻿using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface ICampusService
    {
        CampusDTO GetCampusByID(int campusID);
        IEnumerable<CampusDTO> GetAllCampuses();
        int CreateCampus(CampusDTO campusDTO);
        bool UpdateCampus(int visitorLogID, CampusDTO campusDTO);
        bool DeleteCampus(int visitorLogID);

    }
}
﻿using Repozytorium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repozytorium.IRepo
{
    public interface IZdjecieRepo
    {
        void AddImage(Zdjecie img);
        void DeleteImageByBlobName(string blobName);
        List<Zdjecie> GetAllImages(string userId);
        void SaveChanges();
    }
}
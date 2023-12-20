﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnoucementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnoucementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void TAdd(Announcement t)
        {
            _announcementDal.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _announcementDal.Remove(t);
        }

        public Announcement TGetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> TGetList()
        {
            return _announcementDal.GetList();
        }

        public void TUpdate(Announcement t)
        {
            _announcementDal.Update(t);
        }
    }
}

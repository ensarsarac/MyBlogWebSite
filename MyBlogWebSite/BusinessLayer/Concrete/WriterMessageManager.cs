using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        private readonly IWriterMessageDal _dal;

        public WriterMessageManager(IWriterMessageDal dal)
        {
            _dal = dal;
        }

        public List<WriterMessage> GetListByInbox(string p)
        {
            return _dal.GetList().Where(x => x.Receiver == p).ToList();
        }

        public List<WriterMessage> GetListBySendbox(string p)
        {
            return _dal.GetList().Where(x => x.Sender == p).ToList();
        }

        public void TAdd(WriterMessage t)
        {
            _dal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _dal.Remove(t);
        }

        public WriterMessage TGetById(int id)
        {
            return _dal.GetById(id);
        }

        public List<WriterMessage> TGetList()
        {
            return _dal.GetList();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}

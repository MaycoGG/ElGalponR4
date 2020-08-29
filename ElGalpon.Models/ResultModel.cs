using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElGalpon.Models
{
    public class ResultModel<T>
    {
        public ResultModel()
        {
            this.ErrorMessages = new List<string>();
            this.InfoMessages = new List<string>();
        }
        public bool Ok { get { return !ErrorMessages.Any(); } }
        public T Return { set; get; }
        public List<string> ErrorMessages { set; get; }
        public List<string> InfoMessages { set; get; }

        public string GetFullErrorMessage
        {
            get { return string.Join(",", ErrorMessages); }
        }
        public string GetFullInfoMessages
        {
            get { return string.Join(",", ErrorMessages); }
        }

        public void AddErrorMessage(string msg)
        {
            this.ErrorMessages.Add(msg);
        }
        public void AddInfoMessage(string msg)
        {
            this.InfoMessages.Add(msg);
        }
    }
}

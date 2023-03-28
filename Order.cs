using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreQuery
{
    public class Order
    {
        private string _Id = "";
        [MaxLength(128), Key]
        public string Id
        {
            get { return _Id; }
            set
            {
                if (Id != value)
                {
                    _Id = value;
                }
            }
        }

        private string _Name = "";
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string? _ClientId = null;
        public string? ClientId
        {
            get { return _ClientId; }
            set { _ClientId = value; }
        }

        private int _Total;
        public int Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

    }
}

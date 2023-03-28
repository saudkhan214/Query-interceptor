using System.ComponentModel.DataAnnotations;

namespace EFCoreQuery
{
    public class Customer
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

    }
}
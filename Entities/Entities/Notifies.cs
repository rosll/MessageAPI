using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Notifies
    {
        public Notifies()
        {
            Notifications = new List<Notifies>();
        }

        [NotMapped]
        public string PropertyName { get; set; }

        public string Message { get; set; }

        public List<Notifies> Notifications { get; set; }

        public bool ValidateStringProperty(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Campo obrigatório",
                    PropertyName = propertyName
                });

                return false;
            }

            return true;
        }

        public bool ValidateIntProperty(int value, string propertyName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Campo obrigatório",
                    PropertyName = propertyName
                });

                return false;
            }

            return true;
        }
    }
}

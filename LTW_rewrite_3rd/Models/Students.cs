using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTW_rewrite_3rd.Models
{
    class Students
    {
        private int c01id;
        private string c02lastname;
        private string c03firstname;
        private DateTime c04birthday;
        private bool c05male;
        private string c06phone;
        private string c07address;
        private byte[] c08avatar;

        public Students() { }
        public Students(int c01, string c02, string c03, DateTime c04, bool c05, string c06, string c07, byte[] c08)
        {
            this.c01id = c01;
            this.c02lastname = c02;
            this.c03firstname = c03;
            this.c04birthday = c04;
            this.c05male = c05;
            this.c06phone = c06;
            this.c07address = c07;
            this.c08avatar = c08;
        }

        public int C01_ID { get => c01id; set => c01id = value; }
        public string C02_FirstName { get => c02lastname; set => c02lastname = value; }
        public string C03_LastName { get => c03firstname; set => c03firstname = value; }
        public DateTime C04_Birthday { get => c04birthday; set => c04birthday = value; }
        public bool C05_Male { get => c05male; set => c05male = value; }
        public string C06_Phone { get => c06phone; set => c06phone = value; }
        public string C07_Address { get => c07address; set => c07address = value; }
        public byte[] c08_Avatar { get => c08avatar; set => c08avatar = value; }

    }
}

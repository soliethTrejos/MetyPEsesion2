﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesion_4.clases
{
    /*Calcula el salirio neto del empleaado*/
    internal class Empleado
    {
        public Empleado() { }

        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }

        public Empleado(int iD, string firstname, string lastname, string email, string phone, double salary)
        {
            ID = iD;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Phone = phone;
            Salary = salary;
        }
    }


}

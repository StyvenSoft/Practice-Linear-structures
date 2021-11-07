using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3HugoEcheverri.World.Lists
{
    class Student
    {
        // Atributos
        private int idStudent;
        private String nameStudent;
        private int age;
        private int stratum;
        private String programAcademic;
        private String nameUniversity;
        private String dateRegister;

        public int IdStudent
        {
            get
            {
                return idStudent;
            }

            set
            {
                idStudent = value;
            }
        }

        public string NameStudent
        {
            get
            {
                return nameStudent;
            }

            set
            {
                nameStudent = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public int Stratum
        {
            get
            {
                return stratum;
            }

            set
            {
                stratum = value;
            }
        }

        public string ProgramAcademic
        {
            get
            {
                return programAcademic;
            }

            set
            {
                programAcademic = value;
            }
        }

        public string NameUniversity
        {
            get
            {
                return nameUniversity;
            }

            set
            {
                nameUniversity = value;
            }
        }

        public string DateRegister
        {
            get
            {
                return dateRegister;
            }

            set
            {
                dateRegister = value;
            }
        }

        // Metodo Constructor
        public Student(int idStudent, String nameStudent, int age, int stratum,
                String programAcademic, String nameUniversity, String dateRegister)
        {
            this.idStudent = idStudent;
            this.nameStudent = nameStudent;
            this.age = age;
            this.stratum = stratum;
            this.programAcademic = programAcademic;
            this.nameUniversity = nameUniversity;
            this.dateRegister = dateRegister;
        }
    }
}

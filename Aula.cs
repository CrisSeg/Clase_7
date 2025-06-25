using MetodologíasDeProgramacionI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    public class Aula
    {
        private Teacher teacher;

        public Aula()
        {  }
    
        public void comenzar()
        {
            Console.WriteLine("Comenzando...");
            this.teacher = new Teacher();
        }

        public void nuevoAlumno(IAlumno a) 
        {
            Student stu = new AlumnoAdapter(a);
            this.teacher.goToClass(stu);
        }

        public void claseLista()
        {
            this.teacher.teachingAClass();
        }
    }
}

using NajotTalimCRMDapper.Entities.DTOs;
using NajotTalimCRMDapper.Models;
using System.Runtime.InteropServices;

namespace NajotTalimCRMDapper.MyPettern
{
    public interface IStudentRepository
    {
        public string CreateStudent(StudentDTO studentDTO);
        public IEnumerable<Student> GetAllStudents();
        public Student GetByIdStudent(int id);
        public bool DeleteStudent(int id);
        public Student UpdateStudent(int id, StudentDTO studentDTO);
       
    }
}

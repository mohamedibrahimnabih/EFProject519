using Microsoft.EntityFrameworkCore;

namespace SolveChallenge.Models
{
    [PrimaryKey(nameof(EmployeeId), nameof(Img))]
    class EmployeeImage
    {
        public string Img { get; set; }
        public int EmployeeId { get; set; }
        public double Size { get; set; }
    }
}

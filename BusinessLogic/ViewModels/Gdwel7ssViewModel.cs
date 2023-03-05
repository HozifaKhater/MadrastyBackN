using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class Gdwel7ssViewModel
    {
        public int Id { get; set; }
        public int Ser { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Start { get; set; } = string.Empty;
        public string End { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public string Replacement { get; set; } = string.Empty;
        public int ReplacementId { get; set; }
        public int EmpId { get; set; }
        public int SubjectId { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public int ClassId { get; set; }
        public int LevelId { get; set; }
        public int DepId { get; set; }
        public string LevName { get; set; } = string.Empty;
        public int IsLate { get; set; }
        public int IsBlock { get; set; }
        public int Position { get; set; }
        public string Teacher { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string EventTime { get; set; } = string.Empty;
        public string Day { get; set; } = string.Empty;
    }
}

﻿using LeaveManagement_6.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement_6.Models
{
    public class LeaveRequestVM
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
        public DateTime DateRequested { get; set; }

        public string? RequestComments { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public string? RequestingEmployeeId { get; set; }

        public EmployeeListVM? Employee { get; set; }
    }
}
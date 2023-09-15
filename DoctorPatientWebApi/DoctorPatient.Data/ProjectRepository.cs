using DoctorPatient.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorPatient.Data
{
   public class ProjectRepository
    {

        DemoContext context = null;
        public ProjectRepository( DemoContext context)
        {
            this.context = context;

        }
        public IEnumerable<Project>GetAllProject()
        {
            return context.Project.ToList();
         }
        public void AddProject(Project p)
        {
            context.Project.Add(p);
            context.SaveChanges();
        }
        public void UpdateProject(Project p)
        {
            context.Entry<Project>(p).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            Project p = context.Project.Find(id);
            context.Project.Remove(p);
            context.SaveChanges();
        }
    }
}

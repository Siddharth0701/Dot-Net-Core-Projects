using DoctorPatient.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DoctorPatient.Data
{
   public  class SkillsRepository
    {
        DemoContext context = null;
        public SkillsRepository( DemoContext context)
        {
            this.context = context;
        }

        public IEnumerable<Skill> GetAllSkills()
        {
            return context.Skill.ToList();
        }
        public  void AddSkills(Skill s)
        {
            context.Skill.Add(s);
            context.SaveChanges();
        }
        public void UpdateSkills(Skill s)
        {
            context.Entry<Skill>(s).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteSkills(int id)
        {
            Skill s = context.Skill.Find(id);
            context.Skill.Remove(s);
            context.SaveChanges();
        }
    }
}

﻿using SamiFitnessBL.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiFitnessBL.Controller
{
    public class DatabaseSaver : IDataSaver
    {
        public List<T> Load<T>() where T : class
        {
            using (var db = new FitnessContext())
            {
                var result = db.Set<T>().Where(t => true).ToList();
                return result;
            }
        }

        public void Save<T>(List<T> item) where T : class
        {
            using (var db = new FitnessContext())
            {
                db.Set<T>().AddRange(item);
                db.SaveChanges();
            }
        }
    }
}

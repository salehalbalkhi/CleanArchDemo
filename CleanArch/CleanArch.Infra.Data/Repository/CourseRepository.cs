﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;
        public CourseRepository(UniversityDBContext context)
        {
            _ctx = context;
        }

        public void Add(Course course)
        {
            _ctx.Add(course);
            _ctx.SaveChanges();

        }

        public IQueryable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}

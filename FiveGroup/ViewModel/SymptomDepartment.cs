using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FiveGroup.Models;
using PagedList;

namespace FiveGroup.ViewModel
{
    public class SymptomDepartment
    {
        public List<bodypart> bodypartList { get; set; }
        public List<symptom> symptomList { get; set; }
        public List<department> departmentList { get; set; }
        public List<dep_sym_ref> dep_sym_refList { get; set; }
        public IPagedList<dep_sym_ref> depSymRefPagedList { get; set; }
        public dep_sym_ref depSymRef { get; set; }
    }
}
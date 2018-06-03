using APICode.DAL;
using APICode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICode.BLL
{
    public class ClassifiedService
    {
        public static List<ClassifiedModel> GetClassifieds(string searchQuery)
        {
            var classifiedList = ClassifiedRepository.GetClassifiedList();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                return (from m in classifiedList
                        where m.ClassifiedTitle.StartsWith(searchQuery, StringComparison.CurrentCultureIgnoreCase)
                        select m).ToList();
            }
            return classifiedList;
        }
    }
}
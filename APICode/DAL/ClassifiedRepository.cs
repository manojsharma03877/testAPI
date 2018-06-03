using APICode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICode.DAL
{
    public class ClassifiedRepository
    {
        public static List<ClassifiedModel> classifiedlist;

        public static List<ClassifiedModel> GetClassifiedList()
        {
            if (classifiedlist == null || classifiedlist.Count == 0)
            {
                CreateClassifiedsList();
            }
            return classifiedlist;
        }

        private static void CreateClassifiedsList()
        {
            classifiedlist = new List<ClassifiedModel>()
            {
                new ClassifiedModel()
                {
                    ClassifiedID = 1,
                    ClassifiedTitle = "Car on Sale",
                    ClassifiedDetail = "Car details car details car details",
                    CreatedDate = DateTime.Now,
                    ClassifiedImage = "/carImageUrl.jpg"
                },

                new ClassifiedModel()
                {
                    ClassifiedID = 2,
                    ClassifiedTitle = "House on Sale",
                    ClassifiedDetail = "House details house details house details",
                    CreatedDate = DateTime.Now,
                    ClassifiedImage = "/houseImageUrl.jpg"
                },

                new ClassifiedModel()
                {
                    ClassifiedID = 3,
                    ClassifiedTitle = "Room for rent",
                    ClassifiedDetail = "Room details room details room details",
                    CreatedDate = DateTime.Now,
                    ClassifiedImage = "/roomImageUrl.jpg"
                },

                new ClassifiedModel()
                {
                    ClassifiedID = 4,
                    ClassifiedTitle = "Tree on Sale",
                    ClassifiedDetail = "Tree details tree details tree details",
                    CreatedDate = DateTime.Now,
                    ClassifiedImage = "/treeImageUrl.jpg"
                }

            };
        }
    }
}
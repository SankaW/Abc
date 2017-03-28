using SW01.Data;
using SW01.Data.ISW01Repository;
using SW01.Data.SW01Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SW01.Models.Business
{
    public class PersonBusiness
    {
        public SW01DBEntities context;
        public IPersonReository iPersonRepository;

        public PersonBusiness()
        {
            context = new SW01DBEntities();
            iPersonRepository = new PersonRepository(context);

        }

        // start - data saving method
        public PersonModel SavePerson(PersonModel data)
        {
            try
            {
                Person cv = new Person();

                cv.UserID = data.UserID;
                cv.FristName = data.FristName;
                cv.LastName = data.LastName;
                cv.Gender = data.Gender;
                cv.BirthDate = data.BirthDate;
                cv.GroupName = data.GroupName;
                cv.Good = data.Good;
                cv.Bad = data.Bad;

                var setData = iPersonRepository.Insert(cv);
                if (setData != null)
                {
                    data.UserID = cv.UserID;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return data;

        }
        // end - data saving method

        // start - data updating method
        public PersonModel UpdatePerson(PersonModel data)
        {
            try
            {
                Person cv = new Person();
                cv.UserID = data.UserID;
                cv.FristName = data.FristName;
                cv.LastName = data.LastName;
                cv.Gender = data.Gender;
                cv.BirthDate = data.BirthDate;
                cv.GroupName = data.GroupName;
                cv.Good = data.Good;
                cv.Bad = data.Bad;

                var update = iPersonRepository.Update(cv);
                if (update != null)
                {
                    data.UserID = update.UserID;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return data;
        }
        // end - data updating method

        // start - data retrieving method 
        public IList<PersonModel> RetrievingCVdata(int userID)
        {
            var getData = iPersonRepository.GetList(x => x.UserID == userID);
            var personData = getData.Select(c => new PersonModel
            {
                UserID = c.UserID,
                FristName = c.FristName,
                LastName = c.LastName,
                Gender = c.Gender,
                BirthDate = c.BirthDate,
                GroupName = c.GroupName,
                Good = c.Good,
                Bad = c.Bad
            }).ToList();
            return personData;
        }
        // end - data retrieving method 

        // start - data for grid 
        public IList<PersonModel> DataForGrid()
        {
            var gridData = iPersonRepository.GetAll().Select(c => new PersonModel
            {
                UserID = c.UserID,
                FristName = c.FristName,
                LastName = c.LastName,
                Gender = c.Gender,
                BirthDate = c.BirthDate,
                GroupName = c.GroupName,
                Good = c.Good,
                Bad = c.Bad
            }
            ).OrderBy(t => t.FristName).ToList();

            return gridData;
        }
    }
}
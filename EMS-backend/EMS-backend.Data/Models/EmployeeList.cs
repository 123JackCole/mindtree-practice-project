using System;
using System.Collections.Generic;
using System.Text;

namespace EMS_backend.Data.Models
{
    class EmployeeList
    {
        // pre populated employee data
        public static List<Employee> employeeList = new List<Employee>
        {
            new Employee {
              Id = 1,
              FirstName = "Ephrayim",
              LastName = "Drohan",
              Email = "edrohan0@fema.gov",
              Phone = "273-766-7429",
              DateOfBirth = DateTime.Parse("02/27/1988"),
              Address = "02 Heath Drive",
              Gender = "Male",
              Role = "SDE1" }
            ,
            new Employee {
              Id = 2,
              FirstName = "Benny",
              LastName = "Truter",
              Email = "btruter1@webmd.com",
              Phone = "781-121-0615",
              DateOfBirth = DateTime.Parse("02/10/1987"),
              Address = "9744 Vermont Terrace",
              Gender = "Male",
              Role = "Supervisor"
            },
            new Employee {
              Id = 3,
              FirstName = "Kerry",
              LastName = "Pavluk",
              Email = "kpavluk2@addtoany.com",
              Phone = "913-640-7043",
              DateOfBirth = DateTime.Parse("07/08/1962"),
              Address = "1282 Anzinger Street",
              Gender = "Female",
              Role = "Project Manager"
            },
            new Employee {
              Id = 4,
              FirstName = "Maiga",
              LastName = "Shoesmith",
              Email = "mshoesmith3@comcast.net",
              Phone = "868-704-9877",
              DateOfBirth = DateTime.Parse("12/14/1987"),
              Address = "8561 Browning Trail",
              Gender = "Female",
              Role = "SD3"
            },
            new Employee {
              Id = 5,
              FirstName = "Viola",
              LastName = "Adelman",
              Email = "vadelman4@google.co.jp",
              Phone = "893-657-7144",
              DateOfBirth = DateTime.Parse("04/24/1992"),
              Address = "67194 Hayes Way",
              Gender = "Female",
              Role = "SDE2"
            },
            new Employee {
              Id = 6,
              FirstName = "Naomi",
              LastName = "Traves",
              Email = "ntraves5@myspace.com",
              Phone = "203-564-7818",
              DateOfBirth = DateTime.Parse("01/18/1996"),
              Address = "87 Coolidge Street",
              Gender = "Female",
              Role = "SDE3"
            },
            new Employee {
              Id = 7,
              FirstName = "Gratia",
              LastName = "Boykett",
              Email = "gboykett6@amazon.com",
              Phone = "149-528-0025",
              DateOfBirth = DateTime.Parse("03/23/1941"),
              Address = "0 Arapahoe Place",
              Gender = "Female",
              Role = "SDE1"
            },
            new Employee {
              Id = 8,
              FirstName = "Jessie",
              LastName = "Brimham",
              Email = "jbrimham7@huffingtonpost.com",
              Phone = "348-291-5856",
              DateOfBirth = DateTime.Parse("06/16/1964"),
              Address = "62 Colorado Terrace",
              Gender = "Male",
              Role = "SDE2"
            },
            new Employee {
              Id = 9,
              FirstName = "Bria",
              LastName = "Colt",
              Email = "bcolt8@google.cn",
              Phone = "734-456-5468",
              DateOfBirth = DateTime.Parse("08/02/1986"),
              Address = "458 Russell Street",
              Gender = "Female",
              Role = "Project Manager"
            },
            new Employee {
              Id = 10,
              FirstName = "Debby",
              LastName = "Colgan",
              Email = "dcolgan9@dyndns.org",
              Phone = "214-785-1692",
              DateOfBirth = DateTime.Parse("03/04/1999"),
              Address = "72094 Eastwood Point",
              Gender = "Female",
              Role = "Manager"
            },
            new Employee {
              Id = 11,
              FirstName = "Bax",
              LastName = "Vanin",
              Email = "bvanina@lycos.com",
              Phone = "964-472-7079",
              DateOfBirth = DateTime.Parse("02/18/1950"),
              Address = "094 Kings Plaza",
              Gender = "Male",
              Role = "SDE3"
            },
            new Employee {
              Id = 12,
              FirstName = "Penny",
              LastName = "Wigelsworth",
              Email = "pwigelsworthb@nydailynews.com",
              Phone = "746-157-1424",
              DateOfBirth = DateTime.Parse("01/06/1966"),
              Address = "6528 Sutherland Way",
              Gender = "Female",
              Role = "SDE1"
            },
            new Employee {
              Id = 13,
              FirstName = "Randee",
              LastName = "Degg",
              Email = "rdeggc@china.com.cn",
              Phone = "297-820-5206",
              DateOfBirth = DateTime.Parse("11/04/1947"),
              Address = "314 Raven Center",
              Gender = "Male",
              Role = "SDE2"
            },
            new Employee {
              Id = 14,
              FirstName = "Rosemonde",
              LastName = "Stuer",
              Email = "rstuerd@studiopress.com",
              Phone = "737-396-9785",
              DateOfBirth = DateTime.Parse("01/24/1978"),
              Address = "0480 Quincy Drive",
              Gender = "Male",
              Role = "SDE1"
            },
            new Employee {
              Id = 15,
              FirstName = "Caty",
              LastName = "Boughtflower",
              Email = "cboughtflowere@github.io",
              Phone = "123-573-1718",
              DateOfBirth = DateTime.Parse("07/07/2000"),
              Address = "669 Packers Avenue",
              Gender = "Male",
              Role = "SDE1"
            },
            new Employee {
              Id = 16,
              FirstName = "Griz",
              LastName = "Windas",
              Email = "gwindasf@vinaora.com",
              Phone = "338-349-7294",
              DateOfBirth = DateTime.Parse("04/11/1973"),
              Address = "6182 Longview Trail",
              Gender = "Male",
              Role = "Manager"
            },
            new Employee {
              Id = 17,
              FirstName = "Damara",
              LastName = "Jon",
              Email = "djong@cafepress.com",
              Phone = "826-567-6384",
              DateOfBirth = DateTime.Parse("03/10/1981"),
              Address = "7253 Debs Crossing",
              Gender = "Female",
              Role = "Manager"
            },
            new Employee {
              Id = 18,
              FirstName = "Gerri",
              LastName = "Freshwater",
              Email = "gfreshwaterh@bravesites.com",
              Phone = "683-349-3026",
              DateOfBirth = DateTime.Parse("05/06/1972"),
              Address = "2010 Park Meadow Pass",
              Gender = "Female",
              Role = "SDE3"
            },
            new Employee {
              Id = 19,
              FirstName = "Ariana",
              LastName = "Cutsforth",
              Email = "acutsforthi@foxnews.com",
              Phone = "135-286-5674",
              DateOfBirth = DateTime.Parse("09/05/1992"),
              Address = "4026 Farwell Street",
              Gender = "Female",
              Role = "SDE1"
            },
            new Employee {
              Id = 20,
              FirstName = "Wernher",
              LastName = "Origan",
              Email = "woriganj@rakuten.co.jp",
              Phone = "189-400-3639",
              DateOfBirth = DateTime.Parse("12/02/1941"),
              Address = "04 Farragut Crossing",
              Gender = "Male",
              Role = "SDE2"
            }
        };
    }
}

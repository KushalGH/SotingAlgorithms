using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Sorts;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BubbleSort<int> bubbleSort = new BubbleSort<int>();

            Random random = new Random();
            int[] items = new int[5];
            List<int> vn = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                vn.Add(random.Next());
            }

            items = vn.ToArray();

            bubbleSort.Sort(items);

            return View();
        }

        public ActionResult InsertionSort()
        {

            InsertionSort<int> insertionSort = new InsertionSort<int>();

            Random random = new Random();
            int[] items = new int[5];
            List<int> vn = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                vn.Add(random.Next());
            }

            items = vn.ToArray();

            //
            items = new int[] { 5,3,4,4,9,6,7,1,8 };

            insertionSort.Sort(items);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
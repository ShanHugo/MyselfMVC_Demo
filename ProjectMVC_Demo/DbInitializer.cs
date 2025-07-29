using System;
using System.Linq;
using ProjectMVC.Models;

namespace ProjectMVC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ForProjectContext context)
        {
            // 確保資料庫存在
            context.Database.EnsureCreated();

            // 檢查是否已存在資料
            if (context.Projects.Any())
            {
                return;   // 已初始化過
            }

            // 加入初始資料
            var projects = new Projects[]
            {
                new Projects {
                    Title = "MarryWanna",
                    Description = "探索植物(大麻)與性結合的可能性。",
                    ImageUrl = "/images/marywanna.jpg",
                    Technical = "Unity,Kinect V2、TouchDesigner,Arduino",
                    CreateDate = DateTime.Now
                },
                new Projects {
                    Title = "ASP.NET Core MVC Profile",
                    Description = "本網站，展示個人自傳、作品集、資料庫串接等完整 MVC 架構",
                    ImageUrl = "/images/WebMVC.jpg",
                    Technical = "ASP.NET Core MVC,SQL Server",
                    CreateDate = DateTime.Now
                }
            };

            foreach (var p in projects)
            {
                context.Projects.Add(p);
            }

            context.SaveChanges();
        }
    }
}

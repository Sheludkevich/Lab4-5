﻿using Microsoft.AspNetCore.Mvc;
using WebLabsV05.DAL.Entities;

namespace Lab1.Controllers
{
    public class ProductController : Controller
    {
        List<Dish> _dishes;
        List<DishGroup> _dishGroups;
        public ProductController()
        {
            SetupData();
        }
        public IActionResult Index()
        {
            return View(_dishes);
        }
        /// <summary>
        /// Инициализация списков
        /// </summary>
        private void SetupData()
        {
            _dishGroups = new List<DishGroup>
 {
 new DishGroup {DishGroupId=1, GroupName="Стартеры"},
 new DishGroup {DishGroupId=2, GroupName="Салаты"},
 new DishGroup {DishGroupId=3, GroupName="Супы"},
 new DishGroup {DishGroupId=4, GroupName="Основные блюда"},
 new DishGroup {DishGroupId=5, GroupName="Напитки"},
 new DishGroup {DishGroupId=6, GroupName="Десерты"}
 };
            _dishes = new List<Dish>
 {
 new Dish {DishId = 1, DishName="Щи с кислой капустой",
Description="Без капусты",
Calories =200, DishGroupId=3, Image="Щи.jpg" },
new Dish { DishId = 2, DishName="Борщ",
Description="Много сала, без сметаны",
Calories =330, DishGroupId=3, Image="Борщ.png" },
new Dish { DishId = 3, DishName="Котлета пожарская",
Description="Хлеб - 80%, Морковь - 20%",
Calories =635, DishGroupId=4, Image="Котлета.jpg" },
new Dish { DishId = 4, DishName="Чай",
Description="Индийский чай",
Calories =524, DishGroupId=4, Image="Чай.jpg" },
new Dish { DishId = 5, DishName="Компот",
Description="Быстро растворимый, 2 литра",
Calories =180, DishGroupId=5, Image="Компот.jpg" }
 };
        }
    }

}

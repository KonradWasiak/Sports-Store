﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Infrastructure.Binders
{
    public class CartModelBinder : IModelBinder
    {
        private const string sessionKey = "Cart";

        public Object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            //pobranie obiektu Cart z sesji
            Cart cart = null;
            if(controllerContext.HttpContext.Session != null)
            {
                cart = (Cart)controllerContext.HttpContext.Session[sessionKey];
            }

            //utworzenie obiektu Cart jeżeli nie został znaleziony w danych sesji
            if(cart == null)
            {
                cart = new Cart();
                if(controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = cart;
                }
            }

            //zwracanie koszyka
            return cart;
        }
    }
}
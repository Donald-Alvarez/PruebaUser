using ASPTest.Controllers;
using ASPTest.Models;
using ASPTest.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;
namespace ASPUnitTesting
{
    public class UserTesting
    {

        private readonly UserController _controller;
        private readonly UserService _service;

        public UserTesting()
        {
            _service = new UserService();
            _controller= new UserController(_service);
        }

        [Fact]
        //Manda a llamar un dato.
        public void Get_Ok()
        {
            var result = _controller.Get();
            Assert.IsType<OkObjectResult>(result);
 
        }

        [Fact]
        //Metodo para demostrar que el metodo get si tiene dato. 
        public void Get_Qantity()
        {
            var result = (OkObjectResult)_controller.Get();
            var User = Assert.IsType<List<User>> (result.Value);
            Assert.True(User.Count > 0);
        }

        [Fact]
        //Te manda a pedir un dato por id
        public void GetById_Ok()
        {
            int id = 1;

            var result = _controller.GetById(id);

            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        //Para demostrar si una id es existente
        public void GetById_Exists()
        {
            int id = 1;

            var result = (OkObjectResult)_controller.GetById(id);

            var User = Assert.IsType<User>(result?.Value);
            Assert.True(User != null);
            Assert.Equal(User?.Id_Usuario, id);

        }[Fact]
        //para demostrar la prueba del error que indica que no se encontro un dato con el id definido.
        public void GetById_NotFound()
        {
            int id = 11;

            var result =_controller.GetById(id);

            var User = Assert.IsType<NotFoundResult>(result);
        }
    }
}
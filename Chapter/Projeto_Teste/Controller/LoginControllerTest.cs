using Chapter.Controllers;
using Chapter.Interfaces;
using Chapter.Models;
using Chapter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste.Controller
{
    public class LoginControllerTest
    {
        [Fact]
        public void LoginController_Retornar_Usuario_Invalido()
        {
            //Arrange
            var fakeRepsitory = new Mock<IUsuarioRepository>();
            fakeRepsitory.Setup(x => x.Login(It.IsAny<String>(), It.IsAny<String>())).Returns((Usuario)null);

            LoginViewModel dadosLogin = new LoginViewModel();

            dadosLogin.Email = "email@email.com";
            dadosLogin.Senha = "3421";

            var controller = new LoginController(fakeRepsitory.Object);


            // Act
            var resultado = controller.Login(dadosLogin);

            // Assert
            Assert.IsType<UnauthorizedObjectResult>(resultado);
        }
    }
}
